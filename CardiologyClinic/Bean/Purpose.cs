using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Bean
{
    /**
     * Назначение
     * (прием лекарств или медецинские процедуры)
     */
    public class Purpose : Entity
    {
        /**
         * Пациент которому назначена данная процедура
         */
        private Patient patient;
        /**
         * Процедура назначеная пациенту
         */
        private MedicalProcedure medicalProcedure;
        /**
         * Дата и время выполнения процедуры
         */
        private DateTime dateOfProcedure;
        /**
         * Статус выполнения процедуры
         */
        private bool isComplete;

        public Patient Patient
        {
          get { return patient; }
          set { patient = value; }
        }

        public MedicalProcedure MedicalProcedure
        {
          get { return medicalProcedure; }
          set { medicalProcedure = value; }
        }

        public DateTime DateOfProcedure
        {
            get { return dateOfProcedure; }
            set { dateOfProcedure = value; }
        }           

        public bool IsComplete
        {
            get { return isComplete; }
            set { isComplete = value; }
        }
    }
}
