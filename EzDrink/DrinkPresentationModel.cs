using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EzDrink
{
    public class DrinkPresentationModel
    {
        const int SELECT_COLUMN = 0;
        const int DELETE_COLUMN = 5;
        public DrinkPresentationModel(DrinkModel drinkModel)
        {
            _drinkModel = drinkModel;
            _isAddDrinkList = false;
            _isAddAdditionList = false;
            _drink = new Item();
            _addition = new Item();
            _text = new EzText();
        }

        /// <summary>
        /// 紀錄目前追加的物品名稱
        /// </summary>
        public void SetOrderedName(string name)
        {
            _orderedName = name;
        }

        /// <summary>
        /// 紀錄、回傳目前選擇哪筆被訂的飲料
        /// </summary>
        public int SelectedDrinkIndex
        {
            get
            {
                return _selectedDrinkIndex;
            }
            set
            {
                _selectedDrinkIndex = value;
            }
        }

        /// <summary>
        /// 確認是否符合條件進行結帳
        /// </summary>
        public bool IsCheckOutOk()
        {
            foreach (OrderedDrink drink in _drinkModel.GetOrderList().GetList())
                if (drink.Sugar == "" || drink.Temperature == "")
                    return false && !IsOrderedDrinkEmpty();
            return true && !IsOrderedDrinkEmpty();
        }

        /// <summary>
        /// 確認加料是否重複，若訂單沒飲料回傳false
        /// </summary>
        public bool IsAdditionOrdered(string name)
        {
            if (_drinkModel.GetOrderedDrink(_selectedDrinkIndex) == null)
                return false;
            OrderedDrink drink = _drinkModel.GetOrderedDrink(_selectedDrinkIndex);
            return drink.GetAdditionName().Contains(name);
        }

        /// <summary>
        /// 飲料、加料的選擇判斷，訂單的刪除判斷
        /// </summary>
        public void ClickAndUse(string instruction ,int columnIndex, Action function = null)
        {
            if (instruction == EzText.ORDER && columnIndex == SELECT_COLUMN && !IsAdditionOrdered(_orderedName))
                _drinkModel.OrderDrink(_orderedName, _selectedDrinkIndex);
            if (_text.IsDrink(instruction) || _text.IsAddition(instruction))
                _drinkModel.DeleteItemList(instruction, columnIndex);
            if (instruction == EzText.DELETE && columnIndex == DELETE_COLUMN)
                _drinkModel.DeleteOrderedDrink(_selectedDrinkIndex);
            function();
        }

        /// <summary>
        /// 傳給model目前選到哪杯飲料，還有甜度或溫度的字串
        /// </summary>
        public void SetSugarAndIce(string name, string property)
        {
            _drinkModel.SetDrinkSugarOrIce(name, property, _selectedDrinkIndex);
        }

        /// <summary>
        /// 確認目前訂單是否有飲料
        /// </summary>
        public bool IsOrderedDrinkEmpty()
        {
            return _drinkModel.GetOrderedDrinkCount() == 0;
        }

        /// <summary>
        /// 從檔案匯入資料
        /// </summary>
        public void InputFileData(string listName, string filePath, Action<string, string> function = null)
        {
            if (_drinkModel.SetList(listName, path: filePath) == EzText.ERROR)
                function(EzText.ERROR, EzText.ERROR_TITLE);
        }

        /// <summary>
        /// "新增"按鈕的動作判斷
        /// </summary>
        public void AddItemButtonChange(string buttonName, string buttonText, Action<string, string> function)
        {
            if (_text.IsDrink(buttonName))
            {
                _isAddDrinkList = ButtonChange(_drink, buttonName, buttonText, function);
            }
            if (_text.IsAddition(buttonName))
            {
                _isAddAdditionList = ButtonChange(_addition, buttonName, buttonText, function);
            }
        }

        /// <summary>
        /// 點選取消的判斷
        /// </summary>
        public bool ButtonChange(Item item, string buttonName, string buttonText, Action<string, string> function)
        {
            if (_text.IsAdd(buttonText))
                return true;
            if (_text.IsOk(buttonText) && !String.IsNullOrWhiteSpace(item.Name))
            {
                if (_drinkModel.AddItem(item.Name, item.Price, buttonName))
                    return false;
                else
                    function(EzText.ERROR_REPEAT, EzText.ERROR_TITLE);
            }
            if (_text.IsCancel(buttonText))
                return false;
            return true;
        }

        /// <summary>
        /// 改變後台管理button上的文字
        /// </summary>
        public string ChangeButtonText(string buttonText, string buttonName)
        {
            bool inputState = _text.IsDrink(buttonName) ? _isAddDrinkList : _isAddAdditionList;
            return _text.ChangeText(inputState, buttonText);
        }

        /// <summary>
        /// 紀錄textbox裡輸入的名稱
        /// </summary>
        public void AddItemName(string textBoxName ,string itemName)
        {
            if (_text.IsDrink(textBoxName))
                _drink.Name = itemName;
            else
                _addition.Name = itemName;
        }

        /// <summary>
        /// 紀錄textbox裡輸入的價錢
        /// </summary>
        public void AddItemPrice(string textBoxName, string itemPrice)
        {
            int price = 0;
            int.TryParse(itemPrice, out price);
            if (_text.IsDrink(textBoxName))
                _drink.Price = price;
            else
                _addition.Price = price;
        }

        public bool InputDrink
        {
            get
            {
                return _isAddDrinkList;
            }
            set
            {
                _isAddDrinkList = value;
            }
        }

        public bool InputAddition
        {
            get
            {
                return _isAddAdditionList;
            }
            set
            {
                _isAddAdditionList = value;
            }
        }

        /// <summary>
        /// 確認是否為做讀檔
        /// </summary>
        public bool IsInputFile(string buttonName)
        {
            return _text.IsFileInput(buttonName);
        }

        Item _drink;
        Item _addition;
        private EzText _text;
        private bool _isAddDrinkList;
        private bool _isAddAdditionList;
        private string _orderedName;
        private DrinkModel _drinkModel;
        private int _selectedDrinkIndex;
    }
}
