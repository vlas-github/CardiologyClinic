using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using CardiologyClinic.Dao;
using CardiologyClinic.Help;

namespace CardiologyClinic.Service
{
    class NurseServiceImpl : NurseService
    {
        private PatientDao patientDao =
            (PatientDao)BeanFactory.GetFactory().GetBean("patientDao");
        private RoomDao roomDao =
            (RoomDao)BeanFactory.GetFactory().GetBean("roomDao");
        private PurposeDao purposeDao =
            (PurposeDao)BeanFactory.GetFactory().GetBean("purposeDao");

        public void GetRoomByName(Room room)
        {
            room = this.roomDao.GetRoomByNumber(room);
        }

        public void GetPatientByName(Patient patient)
        {
            this.patientDao.GetPatientByName(patient);
        }

        public ICollection<Room> GetRoomsByNurse(Nurse nurse)
        {
            return this.roomDao.GetRoomsByNurse(nurse);
        }

        public ICollection<Patient> GetPatientByRoom(Room room)
        {
            return this.patientDao.GetPatientsByRoom(room);
        }

        public ICollection<Purpose> GetPurposesByPatient(Patient p)
        {
            return purposeDao.GetPurposesByPatient(p);
        }

        public Purpose GetPurposesById(string id)
        {
            return purposeDao.GetPurposesById(id);
        }

        public bool SavePurpose(Purpose p)
        {
            return purposeDao.Save(p);
        }
    }
}
