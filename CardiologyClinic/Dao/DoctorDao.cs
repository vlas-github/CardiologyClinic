using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Dao
{
    interface DoctorDao
    {
        void Save(Doctor doctor);

        IList<Doctor> GetAllDoctors();

        Doctor GetDoctorByName(Doctor doctor);

        Doctor GetDoctorByPass(string pass);

        Doctor GetDoctorById(string id);
    }
}
