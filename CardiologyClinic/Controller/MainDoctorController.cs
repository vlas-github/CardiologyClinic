using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.View.MainDoctor;
using CardiologyClinic.Bean;
using CardiologyClinic.Service;
using CardiologyClinic.Help;

namespace CardiologyClinic.Controller
{
    public class MainDoctorController
    {
        private User user;
        private MainDoctorForm mainDoctorForm;
        private MainDoctorService mainDoctorService =
            (MainDoctorService)BeanFactory.GetFactory().GetBean("mainDoctorService");

        public MainDoctorController(User user)
        {
            this.user = user;
        }

        public void Start()
        {
            mainDoctorForm = new MainDoctorForm(this);
            mainDoctorForm.ShowMainDoctorName(user.Name);
            mainDoctorForm.Show();
        }

        public void ShowMedicalProcedureEvent()
        {
            List<MedicalProcedure> medicalProcedure =
                mainDoctorService.GetAllMedicalProcedures();
        }

        public void ShowDiseaseEvent()
        {
            throw new NotImplementedException();
        }

        public void ShowDoctorEvent()
        {
            throw new NotImplementedException();
        }

        public void ShowNurseEvent()
        {
            throw new NotImplementedException();
        }

        public void ShowPatientEvent()
        {
            throw new NotImplementedException();
        }

        public void ShowRoomEvent()
        {
            throw new NotImplementedException();
        }
    }
}
