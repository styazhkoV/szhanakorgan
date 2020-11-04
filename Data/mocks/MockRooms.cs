using System.Collections.Generic;
using System.Linq;
using szhanakorgan.Data.Interfaces;
using szhanakorgan.Data.Models;

namespace szhanakorgan.Data.mocks
{
    public class MockRooms : IAllRooms
    {
        private readonly IRoomsCategory _categoryRooms = new MockCategory();
        public IEnumerable<Rooms> Rooms
        {
            get
            {
                return new List<Rooms>
                {
                    new Rooms { 
                        name = "Номер гостиницы № 1",
                        shortDescription = "",
                        longDescription = "",
                        img = "/img/2.jpg",
                        price = 4500,
                        isFavourite = true,
                        avileble = true,
                        Category = _categoryRooms.AllCategories.First()
                    },
                    new Rooms { 
                        name = "Номер гостиницы № 2", 
                        shortDescription = "",
                        longDescription = "",
                        img = "/img/2.jpg",
                        price = 4500,
                        isFavourite = true, 
                        avileble = true, 
                        Category = _categoryRooms.AllCategories.First()
                    },
                    new Rooms {
                        name = "Номер гостиницы № 3",
                        shortDescription = "",
                        longDescription = "",
                        img = "/img/2.jpg",
                        price = 4500,
                        isFavourite = true,
                        avileble = true,
                        Category = _categoryRooms.AllCategories.First()
                    },
                    new Rooms {
                        name = "Номер гостиницы № 4",
                        shortDescription = "",
                        longDescription = "",
                        img = "/img/2.jpg",
                        price = 4500,
                        isFavourite = true,
                        avileble = true,
                        Category = _categoryRooms.AllCategories.Last()
                    },
                    new Rooms {
                        name = "Номер гостиницы № 5",
                        shortDescription = "",
                        longDescription = "",
                        img = "/img/2.jpg",
                        price = 4500,
                        isFavourite = true,
                        avileble = true,
                        Category = _categoryRooms.AllCategories.Last()
                    },
                };
            } 
        }
        public IEnumerable<Rooms> getFavRooms { get; set; }

        public Rooms getObjectRooms(int roomID)
        {
            throw new System.NotImplementedException();
        }
    }

}
