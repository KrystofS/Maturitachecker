using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MaturitaChecker
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
            //SplashForm.ShowSplashScreen();

            if (System.IO.File.Exists("Newtonsoft.Json.dll") != true)
            {
                MessageBox.Show("Nesprávné, nebo chybějící knihovny *.dll", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form1 mainForm = new Form1();
                //SplashForm.CloseForm();
                Application.Run(mainForm);
            }
        }
        //public class SplashForm : Form
        //{
        //    //Delegate for cross thread call to close
        //    private delegate void CloseDelegate();

        //    //The type of form to be displayed as the splash screen.
        //    private static SplashForm splashForm;

        //    static public void ShowSplashScreen()
        //    {
        //        // Make sure it is only launched once.

        //        if (splashForm != null)
        //            return;
        //        Thread thread = new Thread(new ThreadStart(SplashForm.ShowForm));
        //        thread.IsBackground = true;
        //        thread.SetApartmentState(ApartmentState.STA);
        //        thread.Start();
        //    }

        //    static private void ShowForm()
        //    {
        //        splashForm = new SplashForm();
        //        Application.Run(splashForm);
        //    }

        //    static public void CloseForm()
        //    {
        //        splashForm.Invoke(new CloseDelegate(SplashForm.CloseFormInternal));
        //    }

        //    static private void CloseFormInternal()
        //    {
        //        splashForm.Close();
        //        splashForm = null;
        //    }
        //}
    }
}
