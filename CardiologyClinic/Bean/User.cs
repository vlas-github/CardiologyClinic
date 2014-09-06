using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Bean
{
    /**
     * Пользователь системы
     */
    abstract class User : Entity
    {
        /**
         * Имя пользователя
         * (ФИО или Логин)
         */
        private string name;
        /**
         * Hash MD5 пароля пользователя
         */
        private string pass;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return pass; }
            set { pass = value; }
        }
    }
}
