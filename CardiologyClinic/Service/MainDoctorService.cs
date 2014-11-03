using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Service
{
    interface MainDoctorService
    {
        IList<MedicalProcedure> GetAllMedicalProcedures();
        IList<Disease> GetAllDiseases();
        IList<Doctor> GetAllDoctors();
        IList<Nurse> GetAllNurses();
        IList<Patient> GetAllPatients();
        IList<Room> GetAllRooms();

        Patient GetPatientById(String idPatient);
        MedicalProcedure GetMedicalProcedureById(String idMedProc);
        Disease GetDiseaseById(String idDisease);
        Doctor GetDoctorById(String idDoctor);
        Nurse GetNurseById(String idNurse);
        Room GetRoomById(String idRoom);

        void SaveDisease(Disease disease);
        void SaveDoctor(Doctor doctor);
        void SaveMedicalProcedure(MedicalProcedure medicalProcedure);
        void SaveNurse(Nurse nurse);
        void SavePatient(Patient patient);
        void SaveRoom(Room room);
        ICollection<Patient> GetPatientByDoctor(Doctor doctor);
        ICollection<Room> GetRoomsByNurse(Nurse nurse);
        Nurse GetNurseByRoom(Room room);
        ICollection<Patient> GetPatientsByRoom(Room room);
    }
}
