using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using CardiologyClinic.View.PatientView;
using CardiologyClinic.Service;
using CardiologyClinic.Help;

namespace CardiologyClinic.Controller
{
    public class PatientController
    {
        private User user;
        private PatientForm patientForm;
        private PatientService patientService =
            (PatientService)BeanFactory.GetFactory().GetBean("patientService");

        public PatientController(User user)
        {
            this.user = user;
        }

        public void Start()
        {
            patientForm = new PatientForm(this);
            patientForm.ShowPatientName(user.Name);
            patientForm.Show();
        }
    }
}
