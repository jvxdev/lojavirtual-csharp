﻿using AutoMapper;
using LojaVirtual.Controllers.Base;
using LojaVirtual.Libraries.Filters;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Libraries.Manager.Frete;
using LojaVirtual.Libraries.Manager.Shipping;
using LojaVirtual.Libraries.ShoppingKart;
using LojaVirtual.Models;
using LojaVirtual.Models.Const;
using LojaVirtual.Models.ProductAggregator;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class ShoppingKartController : BaseController
    {
        private ILogger<ShoppingKartController> _illoger;

        public ShoppingKartController(ClientLogin clientLogin, IDeliveryAddressRepository deliveryAddressRepository, IProductRepository productRepository, CookieShoppingKart cookieShoppingKart, CookieFrete cookieValorPrazoFrete, IMapper mapper, WSCorreiosCalcularFrete wsCorreios, CalculatePackage calculatePackage, ILogger<ShoppingKartController> illoger) : base(clientLogin, deliveryAddressRepository, productRepository, cookieShoppingKart, cookieValorPrazoFrete, mapper, wsCorreios, calculatePackage)
        {
            _illoger = illoger;
        }


        public IActionResult Index()
        {
            List<ProductItem> productKartItemFull = ReadProductDB();

            return View(productKartItemFull);
        }


        public IActionResult AddItem(int Id)
        {
            Product product = _productRepository.Read(Id);

            if (product == null)
            {
                return View("UnavailableItem");
            }
            else
            {
                var Item = new ProductItem() { Id = Id, ChosenUnits = 1 };
                _cookieShoppingKart.Create(Item);

                return RedirectToAction(nameof(Index));
            }
        }


        [ClientAuthorization]
        public IActionResult DeliveryAddress()
        {
            Client client = _clientLogin.GetClient();
            IList<DeliveryAddress> deliveryAddresses = _deliveryAddressRepository.ReadAll(client.Id);

            ViewBag.Products = ReadProductDB();

            ViewBag.Client = client;
            ViewBag.Addresses = deliveryAddresses;

            return View();
        }


        public IActionResult VerifyStock ()
        {
            List<ProductItem> productKartItemFull = ReadProductDB();

            foreach (var product in productKartItemFull)
            {
                if (product.Stock <= 0)
                {
                    ViewBag.MSG_E = Message.MSG_E009;

                    return View("Index", productKartItemFull);
                }

                if (product.Stock < product.ChosenUnits)
                {
                    ViewBag.MSG_E = Message.MSG_E009;

                    return View("Index", productKartItemFull);
                }
            }

            return RedirectToAction(nameof(DeliveryAddress));
        }


        public IActionResult ChangeAmount(int Id, int Amount)
        {
            Product product = _productRepository.Read(Id);

            if (Amount < 1)
            {
                return BadRequest(new { message = Message.MSG_E008 });
            }
            else if (Amount > product.Stock)
            {
                return BadRequest(new { message = Message.MSG_E009 });
            }
            else
            {
                var Item = new ProductItem() { Id = Id, ChosenUnits = Amount };

                _cookieShoppingKart.Update(Item);

                return RedirectToAction(nameof(Index));
            }
        }


        public IActionResult DeleteItem(int Id)
        {
            _cookieShoppingKart.Delete(new ProductItem() { Id = Id });

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> CalcularFrete(int cepDestino)
        {
            try
            {
                Frete frete = _cookieFrete.Read().Where(a => a.CEP == cepDestino && a.codShoppingKart == HashGenerator(_cookieShoppingKart.Read())).FirstOrDefault();

                if (frete != null)
                {
                    return Ok(frete);
                }
                else
                {
                    List<ProductItem> products = ReadProductDB();

                    List<Package> packages = _calculatePackage.CalculateProductsPackage(products);

                    ValorPrazoFrete valueSEDEX = await _wsCorreios.CalcularFrete(cepDestino.ToString(), CorreiosConst.SEDEX, packages);
                    ValorPrazoFrete valueSEDEX10 = await _wsCorreios.CalcularFrete(cepDestino.ToString(), CorreiosConst.SEDEX10, packages);
                    ValorPrazoFrete valuePAC = await _wsCorreios.CalcularFrete(cepDestino.ToString(), CorreiosConst.PAC, packages);

                    List<ValorPrazoFrete> list = new List<ValorPrazoFrete>();

                    if (valueSEDEX != null) list.Add(valueSEDEX);
                    if (valueSEDEX10 != null) list.Add(valueSEDEX10);
                    if (valuePAC != null) list.Add(valuePAC);

                    frete = new Frete()
                    {
                        CEP = cepDestino,
                        codShoppingKart = HashGenerator(_cookieShoppingKart.Read()),
                        valuesList = list
                    };

                    _cookieFrete.Create(frete);

                    return Ok(frete);
                }
            }
            catch (Exception e)
            {
                _illoger.LogError(e, "ShoppingKartController > CalcularFrete");

                return BadRequest(e);
            }
        }
    }
}
