using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Dao
{
    interface PurposeDao
    {
        ICollection<Purpose> GetPurposesByPatient(Patient p);

        bool Save(Purpose purpose);

        Purpose GetPurposesById(string id);

        IList<Purpose> GetPurposesBetween(DateTime from, DateTime to);
    }
}
