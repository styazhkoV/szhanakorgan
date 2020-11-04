using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using szhanakorgan.Data.Models;

namespace szhanakorgan.Data.Interfaces
{
   public interface IRoomsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
