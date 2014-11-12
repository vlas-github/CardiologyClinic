using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;


namespace CardiologyClinic.Dao
{
    interface MedicalProcedureDao
    {
        void Save(MedicalProcedure medicalProcedure);

        IList<MedicalProcedure> GetAllMedicalProcedures();

        MedicalProcedure GetMedicalProcedureById(string id);

<<<<<<< HEAD
        MedicalProcedure GetMedicalProcedureByName(string p);
=======
        void DeleteMedProc(string id);
>>>>>>> 74e54f6dcd562c07956d6ca0461fec3113f6414b
    }
}
