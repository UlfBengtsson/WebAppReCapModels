using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public class ExDbContext: DbContext
    {
        public ExDbContext(DbContextOptions<ExDbContext> options) : base(options)
        { }
        public DbSet<Car> Cars { get; set; }
    }
}
