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

        public void SaveRoomEvent(Room room)
        {
            this.mainDoctorService.SaveRoom(room);
        }

        public void SavePatientEvent(Patient patient)
        {
            this.mainDoctorService.SavePatient(patient);
        }

        internal IList<Doctor> GetAllDoctors()
        {
            return mainDoctorService.GetAllDoctors();
        }

        internal IList<Disease> GetAllDiseases()
        {
            return mainDoctorService.GetAllDiseases();
        }

        internal IList<Room> GetAllRooms()
        {
            return mainDoctorService.GetAllRooms();
        }

        public Patient GetPatientById(String idPatient)
        {
            Patient patient =
                mainDoctorService.GetPatientById(idPatient);

            return patient;
        }

        public ICollection<Patient> GetPatientByDoctor(Doctor doctor)
        {
            return mainDoctorService.GetPatientByDoctor(doctor);
        }

        public ICollection<Room> GetRoomsByNurse(Nurse nurse)
        {
            return mainDoctorService.GetRoomsByNurse(nurse);
        }

        public Nurse GetNurseByRoom(Room room)
        {
            return mainDoctorService.GetNurseByRoom(room);
        }

        public ICollection<Patient> GetPatientsByRoom(Room room)
        {
            return mainDoctorService.GetPatientsByRoom(room);
        }

        public MedicalProcedure GetMedicalProcedureById(String idMedProc)
        {
            MedicalProcedure medicalProcedure =
                mainDoctorService.GetMedicalProcedureById(idMedProc);

            return medicalProcedure;
        }

        public Disease GetDiseaseById(String idDisease)
        {
            Disease disease =
                mainDoctorService.GetDiseaseById(idDisease);

            return disease;
        }

        public Doctor GetDoctorById(String idDoctor)
        {
            Doctor doctor =
                mainDoctorService.GetDoctorById(idDoctor);

            return doctor;
        }

        public Nurse GetNurseById(String idNurse)
        {
            Nurse nurse =
                mainDoctorService.GetNurseById(idNurse);

            return nurse;
        }

        public Room GetRoomById(String idRoom)
        {
            Room room =
                mainDoctorService.GetRoomById(idRoom);

            return room;
        }

        public void DeleteMedicalProcedure(String idMedProc)
        {
            mainDoctorService.DeleteMedProc(idMedProc);
        }

        public void DeleteDisease(String idDisease)
        {
            mainDoctorService.DeleteDisease(idDisease);
        }

        public void DeleteDoctor(String idDoctor)
        {
            mainDoctorService.DeleteDoctor(idDoctor);
        }

        public void DeleteNurse(String idNurse)
        {
            mainDoctorService.DeleteNurse(idNurse);
        }

        public void DeletePatient(String idPatient)
        {
            mainDoctorService.DeletePatient(idPatient);
        }

        public void DeleteRoom(String idRoom)
        {
            mainDoctorService.DeleteRoom(idRoom);
        }
    }
}
