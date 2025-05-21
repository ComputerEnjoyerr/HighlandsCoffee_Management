using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                using (frmLogin log = new frmLogin())
                {
                    DialogResult result = log.ShowDialog();
                    if (result == DialogResult.OK && log.NextForm != null)
                    {
                        Application.Run(log.NextForm);
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
    }
}
