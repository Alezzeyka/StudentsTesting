using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursach3Domain.Entities;
using System.Data.Entity;

namespace Kursach3Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<TestPreview> TestPreview { get; set; }
    }
}