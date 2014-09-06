using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Bean
{
    /**
     * Лечащий врач
     */
    class Doctor : User
    {
        /**
         * Список поциентов
         */
        private IList<Patient> patients;

        public IList<Patient> Patients
        {
            get { return patients; }
            set { patients = value; }
        }
    }
}
