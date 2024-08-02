﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WebApi.Repositories.Config;



namespace Repositories.EF
{
    public class RepositoryContext : DbContext
    {

        public RepositoryContext(DbContextOptions options) : base(options)
        {



        }


        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
        }

    }
}
