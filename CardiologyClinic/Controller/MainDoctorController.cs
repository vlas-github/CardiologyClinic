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

            mainDoctorForm.ShowMedicalProcedure(medicalProcedure);
        }

        public void ShowDiseaseEvent()
        {
            List<Disease> disease =
                mainDoctorService.GetAllDiseases();

            mainDoctorForm.ShowDisease(disease);
        }

        public void ShowDoctorEvent()
        {
            List<Doctor> doctor =
                mainDoctorService.GetAllDoctors();

            mainDoctorForm.ShowDoctor(doctor);
        }

        public void ShowNurseEvent()
        {
            List<Nurse> nurse =
                mainDoctorService.GetAllNurses();

            mainDoctorForm.ShowNurse(nurse);
        }

        public void ShowPatientEvent()
        {
            List<Patient> patient =
                mainDoctorService.GetAllPatients();

            mainDoctorForm.ShowPatient(patient);
        }

        public void ShowRoomEvent()
        {
            List<Room> room =
                mainDoctorService.GetAllRooms();

            mainDoctorForm.ShowRoom(room);
        }
    }
}
