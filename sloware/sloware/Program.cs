using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using sloware.Models;
using sloware.Views;
using sloware.Presenters;

namespace sloware
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();
            SlowarForm slowarform = new SlowarForm();
            SlowarFormPresenter slowarformpresenter = new SlowarFormPresenter(model, slowarform);

            Application.Run(slowarform);
        }
    }
}
