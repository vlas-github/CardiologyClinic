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

        public void GetRoomByName(Room room)
        {
            room = this.roomDao.GetRoomByNumber(room);
        }

        public void GetPatientByName(Patient patient)
        {
            this.patientDao.GetPatientByName(patient);
        }
    }
}
