using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using CardiologyClinic.Dao;
using CardiologyClinic.Help;

namespace CardiologyClinic.Service
{
    class MainDoctorServiceImpl : MainDoctorService
    {
        private DiseaseDao diseaseDao =
            (DiseaseDao)BeanFactory.GetFactory().GetBean("diseaseDao");
        private DoctorDao doctorDao =
            (DoctorDao)BeanFactory.GetFactory().GetBean("doctorDao");
        private MedicalProcedureDao medicalProcedureDao =
            (MedicalProcedureDao)BeanFactory.GetFactory().GetBean("medicalProcedureDao");
        private NurseDao nurseDao =
            (NurseDao)BeanFactory.GetFactory().GetBean("nurseDao");
        private PatientDao patientDao =
            (PatientDao)BeanFactory.GetFactory().GetBean("patientDao");
        private RoomDao roomDao =
            (RoomDao)BeanFactory.GetFactory().GetBean("roomDao");
        

        public IList<MedicalProcedure> GetAllMedicalProcedures()
        {
            return medicalProcedureDao.GetAllMedicalProcedures();
        }

        public IList<Disease> GetAllDiseases()
        {
            return diseaseDao.GetAllDiseases();
        }

        public IList<Doctor> GetAllDoctors()
        {
            return doctorDao.GetAllDoctors();
        }

        public IList<Nurse> GetAllNurses()
        {
            return nurseDao.GetAllNurse();
        }

        public IList<Patient> GetAllPatients()
        {
            return patientDao.GetAllPatient();
        }

        public IList<Room> GetAllRooms()
        {
            return roomDao.GetAllRoom();
        }

        public void SaveDisease(Disease disease)
        {
            diseaseDao.Save(disease);
        }

        public void SaveDoctor(Doctor doctor)
        {
            doctorDao.Save(doctor);
        }

        public void SaveMedicalProcedure(MedicalProcedure medicalProcedure)
        {
            medicalProcedureDao.Save(medicalProcedure);
        }

        public void SaveNurse(Nurse nurse)
        {
            nurseDao.Save(nurse);
        }

        public void SavePatient(Patient patient)
        {
            patient.Doctor = doctorDao.GetDoctorByName(patient.Doctor);
            patient.Disease = diseaseDao.GetDiseasByName(patient.Disease);
            patient.Room = roomDao.GetRoomByNumber(patient.Room);

            patientDao.Save(patient);
        }

        public void SaveRoom(Room room)
        {
            room.Nurse = nurseDao.GetNurseByName(room.Nurse);
            roomDao.Save(room);
        }

        public Patient GetPatientById(String idPatient)
        {
            return patientDao.GetPatientById(idPatient);
        }

        public MedicalProcedure GetMedicalProcedureById(String idMedProc)
        {
            return medicalProcedureDao.GetMedicalProcedureById(idMedProc);
        }

        public Disease GetDiseaseById(String idDisease)
        {
            return diseaseDao.GetDiseaseById(idDisease);
        }

        public Doctor GetDoctorById(String idDoctor)
        {
            return doctorDao.GetDoctorById(idDoctor);
        }

        public Nurse GetNurseById(String idNurse)
        {
            return nurseDao.GetNurseById(idNurse);
        }

        public Room GetRoomById(String idRoom)
        {
            return roomDao.GetRoomById(idRoom);
        }

        public ICollection<Patient> GetPatientByDoctor(Doctor doctor)
        {
            return patientDao.GetPatientByDoctor(doctor);
        }

        public ICollection<Room> GetRoomsByNurse(Nurse nurse)
        {
            return roomDao.GetRoomsByNurse(nurse);
        }

        public Nurse GetNurseByRoom(Room room)
        {
            return nurseDao.GetNurseByRoom(room);
        }

        public ICollection<Patient> GetPatientsByRoom(Room room)
        {
            return patientDao.GetPatientsByRoom(room);
        }

        public void DeleteMedProc(String idMedProc)
        {
            medicalProcedureDao.DeleteMedProc(idMedProc);
        }

        public void DeleteDisease(String idDisease)
        {
            diseaseDao.DeleteDisease(idDisease);
        }

        public void DeleteDoctor(String idDoctor)
        {
            doctorDao.DeleteDoctor(idDoctor);
        }

        public void DeleteNurse(String idNurse)
        {
            nurseDao.DeleteNurse(idNurse);
        }

        public void DeletePatient(String idPatient)
        {
            patientDao.DeletePatient(idPatient);
        }

        public void DeleteRoom(String idRoom)
        {
            roomDao.DeleteRoom(idRoom);
        }
    }
}
