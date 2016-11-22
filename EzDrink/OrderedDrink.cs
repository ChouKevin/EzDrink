using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class OrderedDrink
    {
        public OrderedDrink()
        {
            _sugar = "";
            _ice = "";
            _additionList = new List<DrinkAddition>();
        }

        /// <summary>
        /// 增加飲料
        /// </summary>
        /// <param name="drink"></param>
        public void SetDrink(Drink drink)
        {
            _orderedDrink = drink;
        }

        /// <summary>
        /// 增加加料
        /// </summary>
        /// <param name="addition"></param>
        public bool AddAddition(DrinkAddition addition)
        {
            string totalAddition = GetAdditionName();
            if (totalAddition.Contains(addition.Name))
                return false; 
            _additionList.Add(addition);
            return true;
        }

        /// <summary>
        /// 取得"飲料"加"加料"的價錢
        /// </summary>
        /// <returns></returns>
        public int GetTotalPrice()
        {
            int totalPrice = 0;
            foreach (DrinkAddition addition in _additionList)
                totalPrice += addition.Price;
            return totalPrice + (_orderedDrink != null ? _orderedDrink.Price : 0);
        }

        /// <summary>
        /// 取得飲料名稱
        /// </summary>
        /// <returns></returns>
        public string GetDrinkName()
        {
            return _orderedDrink.Name;
        }

        /// <summary>
        /// 取得的所有加料名稱
        /// </summary>
        /// <returns></returns>
        public string GetAdditionName()
        {
            const string DOT = ",";
            string additionName = "";
            foreach (DrinkAddition addition in _additionList)
                additionName += addition.Name + DOT;
            return additionName;
        }

        /// <summary>
        /// 設定甜度
        /// </summary>
        public string Sugar
        {
            get
            {
                return _sugar;
            }
            set
            {
                _sugar = value;
            }
        }

        /// <summary>
        /// 設定溫度
        /// </summary>
        public string Temperature
        {
            get
            {
                return _ice;
            }
            set
            {
                _ice = value;
            }
        }

        private string _sugar;
        private string _ice;
        private Drink _orderedDrink;
        private List<DrinkAddition> _additionList;
    }
}
