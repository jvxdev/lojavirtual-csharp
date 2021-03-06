﻿using LojaVirtual.Libraries.Email;
using LojaVirtual.Libraries.Filters;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Libraries.Text;
using LojaVirtual.Models.Const;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace LojaVirtual.Areas.Collaborator.Controllers
{
    [Area("Collaborator")]
    [CollaboratorAuthorization(CollaboratorPositionConst.Manager)]
    public class CollaboratorController : Controller
    {
        private ICollaboratorRepository _collaboratorRepository;
        private EmailManage _emailManage;


        public CollaboratorController(ICollaboratorRepository collaboratorRepository, EmailManage emailManage)
        {
            _collaboratorRepository = collaboratorRepository;
            _emailManage = emailManage;
        }


        public IActionResult Index(int? page)
        {
            IPagedList<Models.Collaborator> collaborators = _collaboratorRepository.ReadAll(page);

            return View(collaborators);
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register([FromForm] Models.Collaborator collaborator)
        {
            ModelState.Remove("Password");

            if (ModelState.IsValid)
            {
                collaborator.Position = CollaboratorPositionConst.Commun;
                collaborator.Password = KeyGenerator.GetUniqueKey(8);
                _collaboratorRepository.Create(collaborator);

                TempData["MSG_S"] = Message.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var categoria = _collaboratorRepository.Read(id);

            return View(categoria);
        }


        [HttpPost]
        public IActionResult Update([FromForm] Models.Collaborator collaborator, int id)
        {
            ModelState.Remove("Password");

            if (ModelState.IsValid)
            {
                _collaboratorRepository.Update(collaborator);

                TempData["MSG_S"] = Message.MSG_S003;

                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        [HttpGet]
        [HttpReferer]
        public IActionResult NewPasswordGenerator(int id)
        {
            Models.Collaborator collaborator = _collaboratorRepository.Read(id);

            collaborator.Password = KeyGenerator.GetUniqueKey(8);

            _collaboratorRepository.UpdatePassword(collaborator);

            _emailManage.NewPasswordEmail(collaborator);

            TempData["MSG_S"] = Message.MSG_S004;

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        [HttpReferer]
        public IActionResult Delete(int id)
        {
            _collaboratorRepository.Delete(id);

            TempData["MSG_S"] = Message.MSG_S002;

            return RedirectToAction(nameof(Index));
        }
    }
}
