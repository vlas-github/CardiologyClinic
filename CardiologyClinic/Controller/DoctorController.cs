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
    }
}
