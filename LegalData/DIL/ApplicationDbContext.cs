using System;
using System.Collections.Generic;
using System.Text;
using LegalData.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LegalData.DIL
{
  public  class ApplicationDbContext:IdentityDbContext<User>
    {
       public DbSet<Lawyer> Lawyers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
    }
}
