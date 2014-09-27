using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Dao;
using CardiologyClinic.Help;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Service
{
    class LoginServiceImpl : LoginService
    {
        private MainDoctorDao mainDoctorDao =
            (MainDoctorDao)BeanFactory.GetFactory().GetBean("mainDoctorDao");
        private DoctorDao doctorDao =
            (DoctorDao)BeanFactory.GetFactory().GetBean("doctorDao");

        public User GetPatientByPass(String pass)
        {
            return null;
        }

        public User GetDoctorByPass(string pass)
        {
            return doctorDao.GetDoctorByPass(pass);
        }

        public User GetNurseByPass(string pass)
        {
            return null;
        }

        public User GetMainDoctorByPass(string pass)
        {
            return mainDoctorDao.GetMainDoctorByPass(pass);
        }
    }
}
