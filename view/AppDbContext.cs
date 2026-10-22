using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using miniProject.ciewModel;

namespace miniProject.viewModel.view
{
    public class AppDbContext : DbContext
    {
        public DbSet<Teacher>  teachers {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = dataBase.db");
        }

        public AppDbContext()
        {
            Database.EnsureCreated();
        }
    }
}