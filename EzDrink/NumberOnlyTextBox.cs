using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink
{
    public partial class NumberOnlyTextBox : TextBox
    {
        public NumberOnlyTextBox()
        {
            this.KeyPress += new KeyPressEventHandler(HandleKeyPress);
        }

        /// <summary>
        /// 不是輸入數字就鎖住
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
