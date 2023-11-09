using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Contexts
{
    public interface ITourDBContext
    {
        public TourDbContext DbContext { get; set; }
    }
}
