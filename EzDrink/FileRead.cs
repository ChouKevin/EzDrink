using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace EzDrink
{
    public class FileRead
    {
        public const string ERROR = "ERROR, Not Find File";
        public const char LINE_FEED = '\n';
        public const string FOLDER = "..\\..\\..\\EzDrink\\TextFile\\";
        public const string FILE_EXTENSION = ".txt";
        public FileRead()
        {
            _fileString = "";
        }

        /// <summary>
        /// 讀檔用
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="fileExtension"></param>
        /// <returns></returns>
        public string Read(string fileName, string fileExtension = FILE_EXTENSION, string path = null)
        {
            string recordString = "";
            if (string.IsNullOrEmpty(path))
                path = FOLDER + fileName + fileExtension;
            try
            {
                StreamReader file = new StreamReader(path, Encoding.Default);
                while ((_fileString = file.ReadLine()) != null)
                {
                    recordString += _fileString + LINE_FEED;
                }
                file.Close();
                return recordString;
            }
            catch
            {
                return ERROR;
            }
        }
        private string _fileString;
    }
}
