﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Service
{
    interface DoctorService
    {
        IList<Patient> GetPatientsByDoctor(User user);

        ICollection<Purpose> GetPurposesByPatient(Patient patient);

        Patient GetPatientById(string p);

        IList<MedicalProcedure> GetAllMedicalProcedure();

        MedicalProcedure GetMedicalProcedureByName(string p);

        void SavePurpose(Purpose purpose);

        IList<Disease> GetAllDiseases();

        Purpose GetPurposeById(string p);
    }
}
