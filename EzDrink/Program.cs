using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();

            DrinkModel drinkModel = new DrinkModel();
            DrinkPresentationModel presentationModel = new DrinkPresentationModel(drinkModel);
            EzDrinkForm ezDrinkForm = new EzDrinkForm(drinkModel, presentationModel);
            Application.Run(ezDrinkForm);
        }
    }
}
