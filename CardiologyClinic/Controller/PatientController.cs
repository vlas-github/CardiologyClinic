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

        public Doctor GetDoctor()
        {
            return ((Patient)user).Doctor;
        }

        public Room GetRoom()
        {
            return ((Patient)user).Room;
        }

        public Nurse GetNurse()
        {
            return ((Patient)user).Room.Nurse;
        }

        public void ShowAllPurpose()
        {
            ((Patient)user).Purposes = patientService.GetPurposesByPatient((Patient)user);
            ICollection<Purpose> result = ((Patient)user).Purposes;
            patientForm.ShowPurpose(result);
        }

        public void ShowNewPurpose()
        {
            ICollection<Purpose> result = new LinkedList<Purpose>();

            ((Patient)user).Purposes = patientService.GetPurposesByPatient((Patient)user);

            foreach (Purpose p in ((Patient)user).Purposes)
            {
                if (!p.IsComplete) result.Add(p);
            }
            patientForm.ShowPurpose(result);
        }

        public void ShowOldPurpose()
        {
            ((Patient)user).Purposes = patientService.GetPurposesByPatient((Patient)user);
            ICollection<Purpose> result = new LinkedList<Purpose>();
            foreach (Purpose p in ((Patient)user).Purposes)
            {
                if (p.IsComplete) result.Add(p);
            }
            patientForm.ShowPurpose(result);
        }

        public DateTime GetDateIn()
        {
            return ((Patient)user).DateIn;
        }

        public DateTime GetDateOut()
        {
            return ((Patient)user).DateOut;
        }
    }
}
