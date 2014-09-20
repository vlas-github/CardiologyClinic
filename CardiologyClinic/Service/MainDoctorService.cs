using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Service
{
    interface MainDoctorService
    {
        List<MedicalProcedure> GetAllMedicalProcedures();
        List<Disease> GetAllDiseases();
        List<Doctor> GetAllDoctors();
        List<Nurse> GetAllNurses();
        List<Patient> GetAllPatients();
        List<Room> GetAllRooms();
        void SaveDisease(Disease disease);
        void SaveDoctor(Doctor doctor);
        void SaveMedicalProcedure(MedicalProcedure medicalProcedure);
    }
}
