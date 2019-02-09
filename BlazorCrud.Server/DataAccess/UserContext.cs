using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCrud.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Server.DataAccess
{
    public class UserContext:DbContext
    {
        public virtual DbSet<User> tblUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2K2A6GN\SQLEXPRESS;Initial Catalog=Assignment4;Trusted_Connection=True;");
            }
        }
    }
}
