using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Bean
{
    /**
     * Лечащий врач
     */
    public class Doctor : User
    {
        /**
         * Список поциентов
         */
        private ICollection<Patient> patients;

        public ICollection<Patient> Patients
        {
            get { return patients; }
            set { patients = value; }
        }
    }
}
