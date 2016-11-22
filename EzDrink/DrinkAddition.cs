using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class DrinkAddition : Item
    {
        public DrinkAddition(string name = "", int price = 0)
        {
            Name = name;
            Price = price;
            this.IsDrink = false;
        }
    }
}
