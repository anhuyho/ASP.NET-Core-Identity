using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationIdentityUser, ApplicationRole, string>
    //public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<TestTable> TestTables { get; set; } 
    }
    public class ApplicationIdentityUser : IdentityUser
    {
        //public string NewColumn { get; set; }
    }
    public class ApplicationRole : IdentityRole
    {
    }
}