using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Dao
{
    interface DoctorDao
    {
        void Save(Bean.Doctor doctor);
    }
}
