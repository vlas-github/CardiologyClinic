﻿using System;
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
        MedicalProcedure GetMedicalProcedureByName(string p);
        void DeleteMedProc(string id);
    }
}
