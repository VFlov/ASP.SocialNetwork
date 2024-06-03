using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ASP.SocialNetwork.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.SocialNetwork.Controllers
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
