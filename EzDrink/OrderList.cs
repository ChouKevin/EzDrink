using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    /// <summary>
    /// 存多個被訂的飲料
    /// </summary>
    public class OrderList
    {
        public OrderList()
        {
            _orderList = new List<OrderedDrink>();
            _time = "";
        }

        /// <summary>
        /// 取得某筆定的飲料
        /// </summary>
        /// <returns></returns>
        public OrderedDrink GetOrderedDrink(int orderListIndex = 0)
        {
            if (orderListIndex >= 0 && orderListIndex < _orderList.Count)
            {
                return _orderList[orderListIndex];
            }
            return null;
        }

        /// <summary>
        /// 回傳所有飲料
        /// </summary>
        /// <returns></returns>
        public List<OrderedDrink> GetList()
        {
            return _orderList;
        }

        /// <summary>
        /// 回傳訂了多少飲料
        /// </summary>
        /// <returns></returns>
        public int GetDrinkCount()
        {
            return _orderList.Count;
        }

        /// <summary>
        /// 新增飲料在點單中
        /// </summary>
        /// <param name="drink"></param>
        public void OrderDrink(Drink drink)
        {
            OrderedDrink orderedDrink = new OrderedDrink();
            orderedDrink.SetDrink(drink);
            _orderList.Add(orderedDrink);
        }

        /// <summary>
        /// 用drinkIndex找要加"加料"的飲料，把加料加進去
        /// </summary>
        /// <param name="drinkIndex"></param>
        /// <param name="addition"></param>
        public bool AddDrinkAddition(int drinkIndex, DrinkAddition addition)
        {
            if (drinkIndex < _orderList.Count && drinkIndex >= 0)
                return _orderList[drinkIndex].AddAddition(addition);
            return false;
        }

        /// <summary>
        /// 刪除飲料
        /// </summary>
        /// <param name="index"></param>
        public bool DeleteDrink(int index)
        {
            if (index >= 0 && index < _orderList.Count)
            {
                _orderList.RemoveAt(index);
                return true;
            }
            return false;
        }

        /// <summary>
        /// 計算價錢
        /// </summary>
        public int CountMoney()
        {
            int totalPrice = 0;
            foreach (OrderedDrink drink in _orderList)
            {
                totalPrice += drink.GetTotalPrice();
            }
            return totalPrice;
        }

        public string Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }

        private List<OrderedDrink> _orderList;
        string _time;
    }
}
