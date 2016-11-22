using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EzDrink
{
    public class DrinkModel
    {
        public DrinkModel()
        {
            _text = new EzText();
            _dataManage = new DataManage();
            _pageList = new PageList();
        }

        /// <summary>
        /// 飲料跟加料的名單全部掃過一次
        /// </summary>
        public void OrderDrink(string name, int orderedDrinkIndex = 0)
        {
            Item item = _dataManage.ExistItem(name);
            _pageList.AddItem(item, orderedDrinkIndex);
        }

        /// <summary>
        /// 取得飲料清單
        /// </summary>
        public List<Drink> GetDrinkData()
        {
            return _dataManage.GetDrinkData();
        }

        /// <summary>
        /// 取得加料種類
        /// </summary>
        public List<DrinkAddition> GetDrinkAddition()
        {
            return _dataManage.GetAdditionData();
        }

        /// <summary>
        /// 取得某頁訂單
        /// </summary>
        public OrderList GetOrderList(int pageNumber = -1)
        {
            return _pageList.GetList(pageNumber);
        }

        /// <summary>
        /// 直接取得現在訂單中的某筆飲料
        /// </summary>
        public OrderedDrink GetOrderedDrink(int orderedDrinkIndex)
        {
            return _pageList.GetOrderDrink(orderedDrinkIndex);
        }

        /// <summary>
        /// 刪除訂單中的某筆飲料
        /// </summary>
        public bool DeleteOrderedDrink(int index)
        {
            return _pageList.DeleteDrink(index);
        }

        /// <summary>
        /// 新增訂單，目前只有1筆訂單
        /// </summary>
        public void AddOrderList()
        {
            _pageList.AddPage();
        }

        /// <summary>
        /// 取得某筆訂單中的飲料數目
        /// </summary>
        public int GetOrderedDrinkCount()
        {
            return _pageList.GetAmountOfDrink();
        }

        /// <summary>
        /// 讀檔設定可增加的飲料、加料
        /// </summary>
        /// <param name="listName"></param>
        /// <param name="fileName"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public string SetList(string listName, string fileName = null, string path = null)
        {
            return _dataManage.ImportFile(listName, fileName, path);
        }

        /// <summary>
        /// 新增飲料、加料
        /// </summary>
        public bool AddItem(string name, int price, string listName)
        {
            return _dataManage.AddData(name, price, listName);
        }

        /// <summary>
        /// 設定飲料甜度、溫度，若property字串有sugar則更改甜度，否則更改溫度
        /// </summary>
        public void SetDrinkSugarOrIce(string name, string property, int orderedDrinkIndex)
        {
            _pageList.SetDrinkProperty(name, property, orderedDrinkIndex);
        }

        /// <summary>
        /// 後台管理的刪除
        /// </summary>
        public void DeleteItemList(string listName, int index)
        {
            _dataManage.Delete(listName, index);
        }

        /// <summary>
        /// 後台修改
        /// </summary>
        public void ModifyItemList(string listName, int index, string header, string value)
        {
            _dataManage.ModifyData(listName, index, header, value);
        }

        /// <summary>
        /// 結帳後儲存結果
        /// </summary>
        public void StoreList()
        {
            _pageList.StorePage();
        }

        /// <summary>
        /// 回傳一筆訂單總價格
        /// </summary>
        public int ListTotalPrice(int pageNumber = -1)
        {
            return _pageList.GetTotalPrice(pageNumber);
        }

        /// <summary>
        /// 取得歷史紀錄
        /// </summary>
        /// <returns></returns>
        public List<OrderList> GetHistoryList()
        {
            return _pageList.GetHistoryRecord();
        }
        private EzText _text;
        private DataManage _dataManage;
        private PageList _pageList;
    }
}
