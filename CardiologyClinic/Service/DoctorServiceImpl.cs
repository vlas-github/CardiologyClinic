using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using CardiologyClinic.Dao;
using CardiologyClinic.Help;

namespace CardiologyClinic.Service
{
    class DoctorServiceImpl : DoctorService
    {
        PatientDao patientDao = (PatientDao)
            BeanFactory.GetFactory().GetBean("patientDao");

        public IList<Patient> GetPatientsByDoctor(User user)
        {
            return patientDao.GetPatientByDoctor(user);
        }
    }
}
