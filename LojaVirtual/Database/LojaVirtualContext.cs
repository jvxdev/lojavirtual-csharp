﻿using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.Database
{
    public class LojaVirtualContext : DbContext
    {
        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options) : base(options)
        {
        }


        public DbSet<Client> Clients { get; set; }


        public DbSet<NewsletterEmail> Newsletter { get; set; }


        public DbSet<Collaborator> Collaborators { get; set; }


        public DbSet<Category> Categories { get; set; }


        public DbSet<Product> Products { get; set; }


        public DbSet<Image> Images { get; set; }
    }
}
