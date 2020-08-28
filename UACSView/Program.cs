using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UACSView.View_CarneMeage;

namespace UACSView
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
            Application.Run(new VIEW_ExitLineSaddle());
            //Application.Run(new Form_AlarmQuery());
        }
    }
}
