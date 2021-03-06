﻿using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace LojaVirtual.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private LojaVirtualContext _database;
        private IConfiguration _conf;


        public CategoryRepository(LojaVirtualContext database, IConfiguration configuration)
        {
            _database = database;
            _conf = configuration;
        }


        public void Create(Category category)
        {
            _database.Add(category);
            _database.SaveChanges();
        }


        public Category Read(int id)
        {
            return _database.Categories.Find(id);
        }


        public Category Read(string slug)
        {
            return _database.Categories.Where(a => a.Slug == slug).FirstOrDefault();
        }


        public Category ReadCategoryName(string name)
        {
            return _database.Categories.Where(a => a.Name == name).FirstOrDefault();
        }


        private List<Category> Categories;
        private List<Category> recursiveCategoryList = new List<Category>();
        public IEnumerable<Category> ReadRecursiveCategories(Category fatherCategory)
        {
            if (Categories == null)
            {
                Categories = ReadAll().ToList();
            }

            if (!recursiveCategoryList.Exists(a => a.Id == fatherCategory.Id))
            {
                recursiveCategoryList.Add(fatherCategory);
            }

            var sonCategoryList = Categories.Where(a => a.FatherCategoryId == fatherCategory.Id);

            if (sonCategoryList.Count() > 0)
            {
                recursiveCategoryList.AddRange(sonCategoryList.ToList());

                foreach (var category in sonCategoryList)
                {
                    ReadRecursiveCategories(category);
                }
            }

            return recursiveCategoryList;
        }


        public IEnumerable<Category> ReadAll()
        {
            return _database.Categories;
        }


        public IPagedList<Category> ReadAll(int? page)
        {
            int registryPerPage = _conf.GetValue<int>("registryPerPage");

            int pageNumber = page ?? 1;
            return _database.Categories.Include(a => a.FatherCategory).ToPagedList<Category>(pageNumber, registryPerPage);
        }


        public List<Category> GetCategoryByFatherCategory(int id)
        {
            return _database.Categories.Where(a => a.FatherCategoryId == id).ToList();
        }


        public void Update(Category category)
        {
            _database.Update(category);
            _database.SaveChanges();
        }


        public void Delete(int id)
        {
            Category category = Read(id);
            _database.Remove(category);
            _database.SaveChanges();
        }
    }
}
