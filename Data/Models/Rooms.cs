using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace szhanakorgan.Data.Models
{
    public class Rooms
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }//ОТОБРАЖАЕТЬСЯ НА ГЛАВНОЙ ИЛИ НЕТ
        public bool avileble { get; set; }//есть ли в наличии
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
