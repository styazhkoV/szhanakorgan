using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using szhanakorgan.Data.Interfaces;
using szhanakorgan.Data.Models;
using szhanakorgan.ViewModels;

namespace szhanakorgan.Controllers
{
    public class RoomController : Controller{

        private readonly IAllRooms _allRooms;
        private readonly IRoomsCategory _allCategories;

        public RoomController(IAllRooms iAllRoom,IRoomsCategory iRoomsCategory)
        {
            _allRooms = iAllRoom;
            _allCategories = iRoomsCategory;
        }

        public ViewResult List()
        {
            //ViewBag.Category = "sdasdasdasdasdadesafdasfasfafa";//Передаёт данные одной строкой
            //var rooms = _allRooms.rooms;//передаваемые данные в HTML страничку
            RoomListVievModel obj = new RoomListVievModel();
            ViewBag.Title = "Жанкорган";
            obj.allRooms = _allRooms.rooms;
            obj.currentCategory = "Комнаты";
            return View(obj);//Подключаемая HTML страница 
        }
    }
}
