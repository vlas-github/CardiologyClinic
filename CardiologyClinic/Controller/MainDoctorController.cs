using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.View.MainDoctorView;
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
            IList<MedicalProcedure> medicalProcedure =
                mainDoctorService.GetAllMedicalProcedures();

            if (medicalProcedure == null) medicalProcedure = new List<MedicalProcedure>();

            mainDoctorForm.ShowMedicalProcedure(medicalProcedure);
        }

        public void ShowDiseaseEvent()
        {
            IList<Disease> disease =
                mainDoctorService.GetAllDiseases();

            if (disease == null) disease = new List<Disease>();

            mainDoctorForm.ShowDisease(disease);
        }

        public void ShowDoctorEvent()
        {
            IList<Doctor> doctor =
                mainDoctorService.GetAllDoctors();

            if (doctor == null) doctor = new List<Doctor>();

            mainDoctorForm.ShowDoctor(doctor);
        }

        public void ShowNurseEvent()
        {
            IList<Nurse> nurse =
                mainDoctorService.GetAllNurses();

            if (nurse == null) nurse = new List<Nurse>();

            mainDoctorForm.ShowNurse(nurse);
        }

        public void ShowPatientEvent()
        {
            IList<Patient> patient =
                mainDoctorService.GetAllPatients();

            if (patient == null) patient = new List<Patient>();

            mainDoctorForm.ShowPatient(patient);
        }

        public void ShowRoomEvent()
        {
            IList<Room> room =
                mainDoctorService.GetAllRooms();

            if (room == null) room = new List<Room>();

            mainDoctorForm.ShowRoom(room);
        }

        public void SaveDiseaseEvent(Disease disease)
        {
            this.mainDoctorService.SaveDisease(disease);
        }

        public void SaveDoctorEvent(Doctor doctor)
        {
            this.mainDoctorService.SaveDoctor(doctor);
        }

        public void SaveMedicalProcedureEvent(MedicalProcedure medicalProcedure)
        {
            this.mainDoctorService.SaveMedicalProcedure(medicalProcedure);
        }

        public void SaveNurseEvent(Nurse nurse)
        {
            this.mainDoctorService.SaveNurse(nurse);
        }

        public IList<Nurse> GetAllNurses()
        {
            return mainDoctorService.GetAllNurses();
        }

        internal void SaveRoomEvent(Room room)
        {
            this.mainDoctorService.SaveRoom(room);
        }
    }
}
