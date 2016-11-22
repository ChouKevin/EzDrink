using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class EzText
    {
        public const string TOTAL_PRICE = "總價";
        public const string FILE_INPUT = "從檔案匯入";
        public const string INPUT_ITEM = "新增";
        public const string CANCEL = "取消";
        public const string OK = "確認";
        public const string DRINK = "drink";
        public const string ADDITION = "addition";
        public const string ERROR = "格式錯誤";
        public const string SUCCESS = "成功";
        public const string ERROR_REPEAT = "資料重複";
        const char LINE_FEED = '\n';
        public const string ERROR_TITLE = "Error";
        public const string DELETE = "刪除";
        public const string ORDER = "選擇";
        public const string ABOUT = "學號 : 103590026\n姓名 : 周冠勳\n更新日期 : 10/24\n版本 : V2.3";
        public EzText()
        {
        }
        
        /// <summary>
        /// 做字串的更換
        /// </summary>
        /// <param name="inputState"></param>
        /// <param name="buttonText"></param>
        /// <returns></returns>
        public string ChangeText(bool inputState, string buttonText)
        {
            if (inputState)
            {
                if (buttonText == FILE_INPUT)
                    return CANCEL;
                if (buttonText == INPUT_ITEM)
                    return OK;
            }
            else
            {
                if (buttonText == CANCEL)
                    return FILE_INPUT;
                if (buttonText == OK)
                    return INPUT_ITEM;
            }
            return buttonText;
        }

        /// <summary>
        /// 回傳字串是不是新增
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsAdd(string input)
        {
            return input == INPUT_ITEM;
        } 

        /// <summary>
        /// 回傳字串是不是取消
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsCancel(string input)
        {
            return input == CANCEL;
        }

        /// <summary>
        /// 回傳字串是否是確認
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsOk(string input)
        {
            return input == OK;
        }

        /// <summary>
        /// 回傳字串是否是檔案輸入
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsFileInput(string input)
        {
            return input == FILE_INPUT;
        }

        /// <summary>
        /// 回傳字串是否是飲料
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsDrink(string input)
        {
            return input.IndexOf(DRINK, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        /// <summary>
        /// 回傳字串是否是加料
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsAddition(string input)
        {
            return input.IndexOf(ADDITION, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        /// <summary>
        /// 將字串做特定符號分割，再回傳
        /// </summary>
        public string[] SplitFileString(string fileString)
        {
            const char BLANK_SPACE = ' ';
            char[] symbol = { BLANK_SPACE, LINE_FEED };
            return fileString.Split(symbol);
        }
    }
}
