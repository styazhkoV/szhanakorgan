using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using szhanakorgan.Data.Interfaces;
using szhanakorgan.Data.Models;

namespace szhanakorgan.Data.Repository
{
    public class RoomRepository : IAllRooms
    {

        private readonly AppDBContent appDBContent;

        public RoomRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Rooms> Rooms => appDBContent.Room.Include(c => c.Category);

        public IEnumerable<Rooms> getFavRooms => appDBContent.Room.Where(p => p.isFavourite).Include(c => c.Category);

        public Rooms getObjectRooms(int roomID) => AppDBContent.Room.FirstOrDefault(p => p.id == roomID);

    }


}
