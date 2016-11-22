using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    /// <summary>
    /// 訂單的操作，
    /// </summary>
    public class PageList
    {
        public PageList()
        {
            _orderListPage = new List<OrderList>();
            AddPage();
            _pageNumber = 0;
        }

        /// <summary>
        /// 新增訂單
        /// </summary>
        public void AddPage()
        {
            _orderListPage.Add(new OrderList());
            _pageNumber++;
        }

        /// <summary>
        /// 儲存訂單
        /// </summary>
        public void StorePage()
        {
            if (_orderListPage[_pageNumber].GetDrinkCount() == 0)
                return;
            _orderListPage[_pageNumber].Time = DateTime.Now.ToString();
            AddPage();
        }

        /// <summary>
        /// 取得某筆編號訂單
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public OrderList GetList(int page)
        {
            try
            {
                return _orderListPage[page];
            }
            catch
            {
                return _orderListPage[_pageNumber];
            }
        }

        /// <summary>
        /// 新增飲料, index 在加加料才用得到
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        public void AddItem(Item item, int index)
        {
            if (item.IsDrink)
                _orderListPage[_pageNumber].OrderDrink((Drink)item);
            else
                _orderListPage[_pageNumber].AddDrinkAddition(index, (DrinkAddition)item);
        }

        /// <summary>
        /// 取得現在訂單中某筆飲料
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public OrderedDrink GetOrderDrink(int index)
        {
            return _orderListPage[_pageNumber].GetOrderedDrink(index);
        }

        /// <summary>
        /// 刪除現在訂單中的某筆飲料
        /// </summary>
        public bool DeleteDrink(int index)
        {
            return _orderListPage[_pageNumber].DeleteDrink(index);
        }

        /// <summary>
        /// 取得訂單中飲料數目
        /// </summary>
        public int GetAmountOfDrink()
        {
            return _orderListPage[_pageNumber].GetDrinkCount();
        }

        /// <summary>
        /// 設定甜度溫度
        /// </summary>
        /// <param name="name"></param>
        /// <param name="property"></param>
        /// <param name="orderedDrinkIndex"></param>
        public void SetDrinkProperty(string name, string property, int orderedDrinkIndex)
        {
            const string SUGAR_STRING = "Sugar";
            if (orderedDrinkIndex >= 0 && orderedDrinkIndex < _orderListPage[_pageNumber].GetDrinkCount())
                if (property.Contains(SUGAR_STRING))
                    _orderListPage[_pageNumber].GetOrderedDrink(orderedDrinkIndex).Sugar = name;
                else
                    _orderListPage[_pageNumber].GetOrderedDrink(orderedDrinkIndex).Temperature = name;
        }

        /// <summary>
        /// 取得某筆訂單總價錢
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public int GetTotalPrice(int pageNumber)
        {
            try
            {
                return _orderListPage[pageNumber].CountMoney();
            }
            catch
            {
                return _orderListPage[_pageNumber].CountMoney();
            }
        }

        /// <summary>
        /// 取得購買的歷史時間
        /// </summary>
        /// <returns></returns>
        public string GetTime(int page)
        {
            return _orderListPage[page].Time;
        }

        /// <summary>
        /// 取得目前有多少筆歷史紀錄
        /// </summary>
        public List<OrderList> GetHistoryRecord()
        {
            List<OrderList> list = new List<OrderList>();
            for (int i = 0; i < _pageNumber; i++)
                list.Add(_orderListPage[i]);
            return list;
        }
        private List<OrderList> _orderListPage;
        int _pageNumber;
    }
}
