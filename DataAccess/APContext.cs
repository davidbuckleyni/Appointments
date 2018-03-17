using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using Microsoft.EntityFrameworkCore;
using DataAccess.Xamarin.Forms_EFCore.Helpers;
using Xamarin.Forms;

namespace DataAccess
{
   public  class APContext : DbContext
    {
        public DbSet<Appointments> Appointments { get; set; }

        private string DatabasePath { get; set; }


       
        public APContext(string dbFullPath)
        {

      

            DatabasePath = dbFullPath;
            this.Database.EnsureCreated();



        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var dbPath = DependencyService.Get<IDBPath>().GetDbPath();
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
