using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using CardiologyClinic.Help;
using CardiologyClinic.Dao;

namespace CardiologyClinic.Service
{
    class PatientServiceImpl : PatientService
    {
        PatientDao patientDao = (PatientDao)
            BeanFactory.GetFactory().GetBean("patientDao");
        PurposeDao purposeDao = (PurposeDao)
            BeanFactory.GetFactory().GetBean("purposeDao");

        public ICollection<Purpose> GetPurposesByPatient(Patient patient)
        {
            return purposeDao.GetPurposesByPatient(patient);
        }

    }
}
