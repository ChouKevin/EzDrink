using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace EzDrink
{
    public partial class EzDrinkForm : Form
    {
        public EzDrinkForm(DrinkModel drinkModel, DrinkPresentationModel presentationModel)
        {
            InitializeComponent();
            _presentationModel = presentationModel;
            _drinkModel = drinkModel;
            SetButton();
            SetAdditionButton();
            _openFile = new OpenFileDialog();
        }

        /// <summary>
        /// menu裡的離開按鈕
        /// </summary>
        private void ClickExitToolStripMenuItem(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 更新加料中Button的狀態
        /// </summary>
        private void SetAdditionButton()
        {
            const int NAME_COLUMN = 1;
            for (int index = 0; index < _drinkAdditionDataView.Rows.Count; index++)
            {
                NewDataGridViewButtonCell cell = (NewDataGridViewButtonCell)_drinkAdditionDataView.Rows[index].Cells[SELECT_BUTTON];
                var name = _drinkAdditionDataView.Rows[index].Cells[NAME_COLUMN].Value;
                cell.Enabled = !_presentationModel.IsAdditionOrdered(name.ToString()) && !_presentationModel.IsOrderedDrinkEmpty();
            }
            _drinkAdditionDataView.Invalidate();
        }

        /// <summary>
        /// 紀錄是哪筆飲料要被更改
        /// </summary>
        private void OrderDataView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _orderDataView.Rows.Count)
            {
                _presentationModel.SelectedDrinkIndex = e.RowIndex;
                _orderDataView.Rows[_presentationModel.SelectedDrinkIndex].Selected = true;
                _presentationModel.ClickAndUse(EzText.DELETE, e.ColumnIndex, OrderUpData);
            }
            SetAdditionButton();
        }

        /// <summary>
        /// 選擇完飲料之後，訂單列表的更新
        /// </summary>
        private void OrderUpData()
        {
            _orderDataView.Rows.Clear();
            foreach (OrderedDrink drink in _drinkModel.GetOrderList().GetList())
                _orderDataView.Rows.Add(drink.GetDrinkName(), drink.GetTotalPrice(), drink.Sugar, drink.Temperature, drink.GetAdditionName());
            OrderTotalPriceCheck();
            _orderDataView.ClearSelection();
            SetButton();
        }
        
        /// <summary>
        /// "選擇"按鈕的事件，"飲料"跟"加料"皆適用，取名稱字串傳入
        /// </summary>
        private void DrinkDataView(object sender, DataGridViewCellEventArgs e)
        {
            const int SECOND_COLUMN = 1;
            if (e.RowIndex >= 0 && e.RowIndex < _drinkDataView.Rows.Count)
            {
                var name = ((DataGridView)sender).Rows[e.RowIndex].Cells[SECOND_COLUMN].Value;
                _presentationModel.SetOrderedName(name.ToString());
                _presentationModel.ClickAndUse(EzText.ORDER, e.ColumnIndex, OrderUpData);
                SetAdditionButton();
            }
        }

        /// <summary>
        /// 計算某筆訂單的價格
        /// </summary>
        private void OrderTotalPriceCheck(int orderNumber = -1)
        {
            const string TOTAL_PRICE = "總價 : ";
            _orderDrinkTotalPrice.Text = TOTAL_PRICE + _drinkModel.ListTotalPrice(orderNumber);
        }

        /// <summary>
        /// 傳入button名稱、文字
        /// </summary>
        private void SetSugarIce(object sender, EventArgs e)
        {
            _presentationModel.SetSugarAndIce(((Button)sender).Text, ((Button)sender).Name);
            OrderUpData();
        }

        /// <summary>
        /// 結帳動作
        /// </summary>
        private void CheckOut(object sender, EventArgs e)
        {
            _drinkModel.StoreList();
            _presentationModel.SelectedDrinkIndex = 0;
            OrderUpData();
            SetEzDrinkData();
            SetAdditionButton();
        }

        /// <summary>
        /// show "About" content
        /// </summary>
        private void ShowMessage(object sender, EventArgs e)
        {
            MessageBox.Show(EzText.ABOUT, ((ToolStripMenuItem)sender).Text);
        }

        /// <summary>
        /// 使用MessageBox
        /// </summary>
        private void UseMessageBox(string content, string title)
        {
            MessageBox.Show(content, title);
        }

        /// <summary>
        /// 後台管理，檔案匯入的按鈕的處理
        /// </summary>
        private void InputFileData(object sender, EventArgs e)
        {
            if (_presentationModel.IsInputFile(((Button)sender).Text))
            {
                _presentationModel.InputFileData((((Button)sender).Name), OpenDialog(), UseMessageBox);
                SetEzDrinkData();
            }
            else
                _presentationModel.AddItemButtonChange((((Button)sender).Name), (((Button)sender).Text), UseMessageBox);
            SetButton();
        }

        /// <summary>
        /// 開啟dialog
        /// </summary>
        /// <returns></returns>
        public string OpenDialog()
        {
            if (_fileDialog.ShowDialog() == DialogResult.OK)
                return _fileDialog.FileName;
            return null;
        }

        /// <summary>
        /// DataGridView刪除的事件
        /// </summary>
        public void ManageListData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ((DataGridView)sender).Rows.Count)
                if (e.ColumnIndex == 0)
                {
                    _drinkModel.StoreList();
                    _presentationModel.ClickAndUse(((DataGridView)sender).Name, e.RowIndex, SetEzDrinkData);
                }
        }

        /// <summary>
        /// 編輯後台
        /// </summary>
        public void ModifyListData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ((DataGridView)sender).Rows.Count)
            {
                _drinkModel.ModifyItemList(((DataGridView)sender).Name, e.RowIndex, ((DataGridView)sender).Columns[e.ColumnIndex].HeaderText, ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                SetEzDrinkData();
            }
        }

        /// 按下新增、從檔案匯入按鈕時呼叫
        public void AddListButton(object sender, EventArgs e)
        {
            _presentationModel.AddItemButtonChange(((Button)sender).Name, ((Button)sender).Text, UseMessageBox);
            SetButton();
            SetEzDrinkData();
        }

        /// 新增飲料、加料清單的名稱
        public void InputItemName(object sender, EventArgs e)
        {
            _presentationModel.AddItemName(((TextBox)sender).Name, ((TextBox)sender).Text);
        }

        /// 新增飲料、加料清單的價錢
        public void InputItemPrice(object sender, EventArgs e)
        {
            _presentationModel.AddItemPrice(((TextBox)sender).Name, ((TextBox)sender).Text);
        }

        /// 詳細資料裡面的顯示更新
        private void RecordUpData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && e.RowIndex >= _drinkModel.GetHistoryList().Count)
                return;
            _presentationModel.SelectedDrinkIndex = e.RowIndex;
            RecordDataUpData();
            _recordTotalPriceLabel.Text = EzText.TOTAL_PRICE + _drinkModel.GetHistoryList()[e.RowIndex].CountMoney().ToString();
        }
        private OpenFileDialog _openFile;
        private DrinkModel _drinkModel;
        private DrinkPresentationModel _presentationModel;
        const int SELECT_BUTTON = 0;
    }
}
