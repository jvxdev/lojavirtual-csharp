﻿using LojaVirtual.Database;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories.Contracts
{
    public class NewsletterRepository : INewsletterRepository
    {
        private LojaVirtualContext _database;

        public NewsletterRepository(LojaVirtualContext database)
        {
            _database = database;
        }

        public void Create(NewsletterEmail newsletter)
        {
            _database.NewsletterEmails.Add(newsletter);
            _database.SaveChanges();
        }

        public IEnumerable<NewsletterEmail> ReadAll()
        {
            return _database.NewsletterEmails.ToList();
        }
    }
}
