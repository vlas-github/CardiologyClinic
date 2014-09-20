using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Dao
{
    interface DiseaseDao
    {
        void Save(Disease disease);
    }
}
