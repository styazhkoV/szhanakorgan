using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using szhanakorgan.Data.Interfaces;
using szhanakorgan.Data.Models;

namespace szhanakorgan.Data.mocks
{
    public class MockCategory : IRoomsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ categoryName = "Одноместные номера", categoryDescription = "Простоые и удобные номера"},
                    new Category{ categoryName = "Двухместные номера", categoryDescription = "Просторные и элитные номера"}
                    //Сюда можно добавлять новые категории комнат на сайт, по шаблону выше
                };
            }
        }
    }
}
    
