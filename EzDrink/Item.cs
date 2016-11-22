using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EzDrink
{
    public class Item
    {
        public Item()
        {
            _name = "";
            _price = 0;
            _isDrink = true;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public bool IsDrink
        {
            get
            {
                return _isDrink;
            }
            set
            {
                _isDrink = value;
            }
        }
        
        private bool _isDrink;
        private int _price;
        private string _name;
    }
}
