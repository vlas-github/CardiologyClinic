using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Dao
{
    interface MedicalProcedureDao
    {
        void Save(Bean.MedicalProcedure medicalProcedure);
    }
}
