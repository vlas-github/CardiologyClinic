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
        void SaveDisease(Disease disease);
        void SaveDoctor(Doctor doctor);
        void SaveMedicalProcedure(MedicalProcedure medicalProcedure);
        void SaveNurse(Nurse nurse);
        void SavePatient(Patient patient);
        void SaveRoom(Room room);
    }
}
