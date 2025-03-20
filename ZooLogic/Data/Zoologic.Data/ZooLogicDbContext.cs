using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ZooLogic.web.Data
{
    public class ZooLogicDbContext : IdentityDbContext
    {
        public ZooLogicDbContext(DbContextOptions<ZooLogicDbContext> options)
            : base(options)
        {
        }
    }
}
