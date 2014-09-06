using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Bean
{
    /**
     * Больничная палата
     */
    class Room : Entity
    {
        /**
         * Номер палаты
         */
        private int number;
        /**
         * Список пациентов в палате
         */
        private IList<Patient> patients;
        /**
         * Медсестра, ответственная за палатой
         */
        private Nurse nutse;
        /**
         * Размер палаты (кол-во пациентов)
         */
        private int size;
        /**
         * Ответственная медсестра
         */
        private Nurse nurse;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public IList<Patient> Patients
        {
            get { return patients; }
            set { patients = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Nurse Nurse
        {
            get { return nurse; }
            set { nurse = value; }
        }
    }
}
