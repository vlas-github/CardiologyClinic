using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CardiologyClinic.Help;

namespace CardiologyClinic
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MySqlConnector m = (MySqlConnector)MySqlConnector.GetInstance();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
