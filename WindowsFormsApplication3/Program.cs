using System;
using System.Windows.Forms;

namespace WindowsFormsApplication3
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

            FormResolve.Wire(FormModule.Create());
            Application.Run(FormResolve.Resolve<Form1>());
        }    
    }
}
