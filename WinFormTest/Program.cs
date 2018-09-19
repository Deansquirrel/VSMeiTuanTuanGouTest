using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormTest
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
            Application.Run(new FrmStart
            {
                StartPosition = FormStartPosition.CenterScreen,
                Width = 1000,
                Height = 600,
                FormBorderStyle = FormBorderStyle.FixedSingle
            });
        }
    }
}
