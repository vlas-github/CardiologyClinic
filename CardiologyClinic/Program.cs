using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CardiologyClinic.Help;
using CardiologyClinic.View.Login;
using CardiologyClinic.Controller;
using CardiologyClinic.Service;
using CardiologyClinic.Dao;

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

            MainDoctorDao mainDoctorDao = new MainDoctorDaoImpl();
            factory.PutBean("mainDoctorDao", mainDoctorDao);

            LoginService loginService = new LoginServiceImpl();
            factory.PutBean("loginService", loginService);

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginController loginController = new LoginController();
            loginController.Start();
        }
    }
}
