using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using szhanakorgan.Data.Models;

namespace szhanakorgan.Data.Interfaces
{
    public interface IAllRooms
    {
        IEnumerable<Rooms> Rooms { get; }
        IEnumerable<Rooms> getFavRooms { get; }
        Rooms getObjectRooms(int roomID);
    }
}
