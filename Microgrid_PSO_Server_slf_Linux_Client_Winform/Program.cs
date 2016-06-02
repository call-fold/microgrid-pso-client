using System;
using System.Windows.Forms;

namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new User());
        }
    }
}
