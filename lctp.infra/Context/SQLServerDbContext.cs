using lctp.libs.Models;
using Microsoft.EntityFrameworkCore;

namespace lctp.infra.Context
{
    public class SQLServerDbContext : DbContext
    {
        public SQLServerDbContext(DbContextOptions<SQLServerDbContext> context) : base(context)
        {

        }

        public DbSet<UserModel> Users { get;set; }
    }
}
