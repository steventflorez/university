using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using university_backent.Models.DataModels;

namespace university_backent.Data
{
    public class university_backentContext : DbContext
    {
        public university_backentContext (DbContextOptions<university_backentContext> options)
            : base(options)
        {
        }

        public DbSet<university_backent.Models.DataModels.User> User { get; set; } = default!;
    }
}
