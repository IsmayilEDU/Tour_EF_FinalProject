using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases.Contexts
{
    public interface ITourDBContext
    {
        public TourDbContext DbContext { get; set; }
    }
}
