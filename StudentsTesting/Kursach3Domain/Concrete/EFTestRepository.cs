using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursach3Domain.Entities;
using Kursach3Domain.Abstract;

namespace Kursach3Domain.Concrete
{
    public class EFTestRepository : ITestRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<TestPreview> TestPreview
        { 
            get { return context.TestPreview; }
        }
    }
}