using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using NautaFootball.Emails;
using NautaFootball.Users;

namespace NautaFootball.Data
{
    public class NautaFootballDbContext : IdentityDbContext<ApplicationUser>
    {
        public NautaFootballDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static NautaFootballDbContext Create()
        {
            return new NautaFootballDbContext();
        }

        public DbSet<Email> Emails { get; set; }
    }
}
