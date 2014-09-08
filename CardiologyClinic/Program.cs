using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CardiologyClinic.Help;
using CardiologyClinic.View.MainDoctor;

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
            BeanFactory factory = BeanFactory.GetFactory();

            MySqlConnector connector = new MySqlConnector();
            connector.Configure();
            // connector.CreateTables(); 
            factory.PutBean("connector", connector);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainDoctorForm());
        }
    }
}
