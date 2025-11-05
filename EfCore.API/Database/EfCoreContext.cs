using Microsoft.EntityFrameworkCore;

namespace EfCore.API.Database
{
    public class EfCoreContext : DbContext
    {
        public EfCoreContext(DbContextOptions<EfCoreContext> options) : base(options)
        {

        }
    }
}
