using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CardiologyClinic.Help;
using CardiologyClinic.View.LoginView;
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
            // Create Bean Factory
            BeanFactory factory = BeanFactory.GetFactory();

            // Create and configure connecor and add it in Bean Factory
            MySqlConnector connector = new MySqlConnector();
            connector.Configure();
            //connector.CreateTables();
            factory.PutBean("connector", connector);

            // Add Dao to Bean Factory
            factory.PutBean("diseaseDao",           new DiseaseDaoImpl());
            factory.PutBean("doctorDao",            new DoctorDaoImpl());
            factory.PutBean("mainDoctorDao",        new MainDoctorDaoImpl());
            factory.PutBean("medicalProcedureDao",  new MedicalProcedureDaoImpl());
            factory.PutBean("nurseDao",             new NurseDaoImpl());
            factory.PutBean("patientDao",           new PatientDaoImpl());
            factory.PutBean("purposeDao",           new PurposeDaoImpl());
            factory.PutBean("roomDao",              new RoomDaoImpl());

            // Add Service to Bean Factory
            factory.PutBean("doctorService", new DoctorServiceImpl());
            factory.PutBean("loginService", new LoginServiceImpl());
            factory.PutBean("mainDoctorService", new MainDoctorServiceImpl());
            factory.PutBean("nurseService", new NurseServiceImpl());
            factory.PutBean("patientService", new PatientServiceImpl());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginController loginController = new LoginController();
            loginController.Start();
        }
    }
}
