using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcceess.Concrete.EntityFramework.Contexts
{
    public class WebDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS; Initial Catalog=afetgiris; Integrated Security=True; Persist Security Info=False");
            base.OnConfiguring(optionsBuilder);

        }
    }


}
