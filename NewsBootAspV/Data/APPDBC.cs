using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NewsBootAspV.Data
{
    public class APPDBC : IdentityDbContext<ApplicationUser>
    {
        public APPDBC(DbContextOptions<APPDBC> options)
            : base(options)
        {
        }
    }
}
