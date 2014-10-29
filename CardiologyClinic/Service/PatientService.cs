using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Service
{
    interface PatientService
    {
        ICollection<Purpose> GetPurposesByPatient(Patient patient);
    }
}
