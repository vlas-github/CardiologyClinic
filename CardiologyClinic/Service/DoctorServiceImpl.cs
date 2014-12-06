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
        PurposeDao purposeDao = (PurposeDao)
            BeanFactory.GetFactory().GetBean("purposeDao");
        MedicalProcedureDao medicalProcedureDao = (MedicalProcedureDao)
            BeanFactory.GetFactory().GetBean("medicalProcedureDao");
        DiseaseDao diseaseDao = (DiseaseDao)
            BeanFactory.GetFactory().GetBean("diseaseDao");

        public IList<Patient> GetPatientsByDoctor(User user)
        {
            return patientDao.GetPatientByDoctor(user);
        }

        public ICollection<Purpose> GetPurposesByPatient(Patient patient)
        {
            return purposeDao.GetPurposesByPatient(patient);
        }

        public Patient GetPatientById(string p)
        {
            return patientDao.GetPatientById(p);
        }

        public IList<MedicalProcedure> GetAllMedicalProcedure()
        {
            return medicalProcedureDao.GetAllMedicalProcedures();
        }

        public MedicalProcedure GetMedicalProcedureByName(string p)
        {
            return medicalProcedureDao.GetMedicalProcedureByName(p);
        }

        public void SavePurpose(Purpose purpose)
        {
            purposeDao.Save(purpose);
        }

        public IList<Disease> GetAllDiseases()
        {
            return diseaseDao.GetAllDiseases();
        }
    }
}
