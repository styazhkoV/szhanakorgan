using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using szhanakorgan.Data.Models;

namespace szhanakorgan.ViewModels
{
    public class RoomListVievModel
    {
        public IEnumerable<Rooms>allRooms { get; set; }

        public string currentCategory { get; set; }
    }
}
