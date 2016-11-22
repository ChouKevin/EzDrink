using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class Drink : Item
    {
        public Drink(string name = "", int price = 0)
        {
            Name = name;
            Price = price;
            this.IsDrink = true;
        }
    }
}
