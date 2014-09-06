using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Bean
{
    /**
     * Сущность для хранения справочной информации
     */
    abstract class Catalog : Entity
    {
        /**
         * Название сущности
         */
        private string name;
        /**
         * Описание сущности
         */
        private string description;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
