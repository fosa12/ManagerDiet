using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Persistance
{
    public class DietDbContextFactory : DesignTimeDbContextFactoryBase<DietDbContext>
    {
        protected override DietDbContext CreateNewInstance(DbContextOptions<DietDbContext> options)
        {
            return new DietDbContext(options);
        }
    }
}
