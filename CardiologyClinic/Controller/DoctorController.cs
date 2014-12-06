using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using CardiologyClinic.View.DoctorView;
using CardiologyClinic.Service;
using CardiologyClinic.Help;
using CardiologyClinic.View.DoctorView.EditPatient.EditProcedure;
using CardiologyClinic.View.DoctorView.InfoEditPatient;

namespace CardiologyClinic.Controller
{
    public class DoctorController
    {
        private User user;
        private DoctorForm doctorForm;
        private DoctorService doctorService =
            (DoctorService)BeanFactory.GetFactory().GetBean("doctorService");

        public DoctorController(User user)
        {
            this.user = user;
        }

        public void Start()
        {
            doctorForm = new DoctorForm(this);
            doctorForm.ShowDoctorName(user.Name);
            doctorForm.Show();
        }

        public void ShowAllPatientEvent()
        {
            IList<Patient> patients = doctorService.GetPatientsByDoctor(user);
            doctorForm.ShowAllPatients(patients);
        }

        public ICollection<Purpose> GetPurposesByPatient(Patient patient)
        {
            return doctorService.GetPurposesByPatient(patient);
        }

        public void AddProcedureEvent(Patient patient)
        {
            new AddProcedureForm(this, patient).ShowDialog();
        }

        public Patient GetPatientById(string p)
        {
            return doctorService.GetPatientById(p);
        }

        public void EditPatientEvent(Patient patient)
        {
            new PatientIEditForm(this, patient).ShowDialog();
        }

        public IList<MedicalProcedure> GetAllMedicalProcedure()
        {
            return doctorService.GetAllMedicalProcedure();
        }

        public MedicalProcedure GetMedicalProcedureByName(string p)
        {
            return doctorService.GetMedicalProcedureByName(p);
        }

        public void SavePurpose(Purpose purpose)
        {
            doctorService.SavePurpose(purpose);
        }

        public IList<string> GetAllDiseases()
        {
            IList<string> result = new List<string>();
            foreach (Disease d in doctorService.GetAllDiseases())
            {
                result.Add(d.Name);
            }
            return result;
        }

        public Purpose GetPurposeById(string p)
        {
            return doctorService.GetPurposeById(p);
        }

        public void EditPurposeEvent(Purpose purpose, Patient patient)
        {
            new AddProcedureForm(this, purpose, patient).ShowDialog();
        }
    }
}
