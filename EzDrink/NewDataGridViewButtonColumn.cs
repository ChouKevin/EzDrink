using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EzDrink
{
    public class NewDataGridViewButtonColumn : DataGridViewButtonColumn
    {
        public NewDataGridViewButtonColumn()
        {
            this.CellTemplate = new NewDataGridViewButtonCell();
        }
    }
}
