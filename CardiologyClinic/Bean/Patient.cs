using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Bean
{
    /**
     * Пациент кардиалогического диспансера
     */
    class Patient : User
    {
        /**
         * Список назначений пациента (прием лекарств и лечебные процедуры)
         */
        private IList<Purpose> purposes;
        /**
         * Комната в которой проживает пациент (ID)
         */
        private Room room;
        /**
         * Лечащий врач пациента (ID)
         */
        private Doctor doctor;
        /**
         * Дата заселения пациента
         */
        private DateTime dateIn;
        /**
         * Дата выписки пациента
         */
        private DateTime dateOut;
        /**
         * Диагноз пациента (ID)
         */
        private Disease disease;

        public IList<Purpose> Purposes
        {
            get { return purposes; }
            set { purposes = value; }
        }

        public Room Room
        {
            get { return room; }
            set { room = value; }
        }

        public Doctor Doctor
        {
            get { return doctor; }
            set { doctor = value; }
        }

        public DateTime DateIn
        {
            get { return dateIn; }
            set { dateIn = value; }
        }

        public DateTime DateOut
        {
            get { return dateOut; }
            set { dateOut = value; }
        }

        public Disease Disease
        {
            get { return disease; }
            set { disease = value; }
        }
    }
}
