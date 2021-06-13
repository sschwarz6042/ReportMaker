using ReportMaker.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportMaker
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //
            //Testing MenuItemGenerator
            //
            
            //Console.WriteLine("Testing link gen\n");
            //string LinkGenTestInput = "suspensions without maximum days";
            //Console.WriteLine("Link Gen Test Input = " + LinkGenTestInput + "\n");
            //Console.WriteLine("Test Output = \n" + MenuItemGenerator.CreateSingleLink(LinkGenTestInput));

            

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
