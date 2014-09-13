using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Bean
{
    /**
     * Базовая сущность приложения
     */
    public abstract class Entity
    {
        /**
         * UUID Сущности
         */
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
