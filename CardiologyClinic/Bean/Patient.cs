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
        private string room;
        /**
         * Лечащий врач пациента (ID)
         */
        private string doctor;
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
        private string disease;

        public IList<Purpose> Purposes
        {
            get { return purposes; }
            set { purposes = value; }
        }

        public string Room
        {
            get { return room; }
            set { room = value; }
        }

        public string Doctor
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

        public string Disease
        {
            get { return disease; }
            set { disease = value; }
        }
    }
}
