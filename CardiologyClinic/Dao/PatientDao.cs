using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Dao
{
    interface PatientDao
    {
        void Save(Patient patient);

        IList<Patient> GetAllPatient();

        User GetPatientByPass(string pass);

        IList<Patient> GetPatientByDoctor(User user);

        void GetPatientByName(Patient patient);

        Patient GetPatientById(string id);

        ICollection<Patient> GetPatientsByRoom(Room room);
    }
}
