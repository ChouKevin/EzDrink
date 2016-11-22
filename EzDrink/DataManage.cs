using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class DataManage
    {
        public DataManage()
        {
            _text = new EzText();
            _fileRead = new FileRead();
            _drinkData = new List<Drink>();
            _drinkAddition = new List<DrinkAddition>();
        }
        
        /// <summary>
        /// 更改資料
        /// </summary>
        /// <param name="listName"></param>
        /// <param name="index"></param>
        /// <param name="header"></param>
        /// <param name="value"></param>
        public void ModifyData(string listName, int index, string header, string value)
        {
            int price = 0;
            const string NAME = "名稱";
            if (_text.IsDrink(listName) && index >= 0 && index < _drinkData.Count)
                if (header == NAME)
                    _drinkData[index].Name = value;
                else
                    _drinkData[index].Price = int.TryParse(value, out price) ? int.Parse(value) : price;
            if (_text.IsAddition(listName) && index >= 0 && index < _drinkAddition.Count)
                if (header == NAME)
                    _drinkAddition[index].Name = value;
                else
                    _drinkAddition[index].Price = int.TryParse(value, out price) ? int.Parse(value) : price;
        }

        /// <summary>
        /// 增加資料
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="listName"></param>
        /// <returns></returns>
        public bool AddData(string name, int price, string listName)
        {
            var item = ExistItem(name);
            if (item == null)
            {
                if (_text.IsDrink(listName))
                    _drinkData.Add(new Drink(name, price));
                else if (_text.IsAddition(listName))
                    _drinkAddition.Add(new DrinkAddition(name, price));
            }
            return item == null && (_text.IsDrink(listName) || _text.IsAddition(listName));
        }

        /// <summary>
        /// 資料刪除
        /// </summary>
        public void Delete(string listName, int index)
        {
            if (index >= 0 && index < _drinkData.Count)
                if (_text.IsDrink(listName))
                    _drinkData.RemoveAt(index);
            if (index >= 0 && index < _drinkAddition.Count)
                if (_text.IsAddition(listName))
                    _drinkAddition.RemoveAt(index);
        }

        /// <summary>
        /// 從檔案設定飲料、加料
        /// </summary>
        public string ImportFile(string listName, string fileName = null, string path = null)
        {
            const int ONE = 1;
            string fileString = _fileRead.Read(fileName, path: path);
            string[] words = _text.SplitFileString(fileString);
            for (int i = 0; i < _text.SplitFileString(fileString).Length - ONE; i++)
            {
                try
                {
                    if (AddData(words[i], int.Parse(words[++i]), listName) == false)
                        return EzText.ERROR;
                }
                catch
                {
                    return EzText.ERROR;
                }
            }
            return EzText.SUCCESS;
        }

        /// <summary>
        /// 找到已經存在過的飲料或加料，然後回傳
        /// </summary>
        public Item ExistItem(string name)
        {
            Item item = null;
            foreach (Drink drink in _drinkData)
                if (drink.Name == name)
                {
                    item = drink;
                }
            foreach (DrinkAddition drinkAddition in _drinkAddition)
                if (drinkAddition.Name == name)
                {
                    item = drinkAddition;
                }
            return item;
        }

        /// <summary>
        /// 回傳可增加的飲料
        /// </summary>
        /// <returns></returns>
        public List<Drink> GetDrinkData()
        {
            return _drinkData;
        }

        /// <summary>
        /// 回傳可增加的加料
        /// </summary>
        /// <returns></returns>
        public List<DrinkAddition> GetAdditionData()
        {
            return _drinkAddition;
        }

        private EzText _text;
        private FileRead _fileRead;
        private List<Drink> _drinkData;
        private List<DrinkAddition> _drinkAddition;
    }
}
