using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Help
{
    /**
     * Хранилище объектов системы
     */
    class BeanFactory
    {
        private static BeanFactory instance;

        private SortedDictionary<string, Object> beans = new SortedDictionary<string, Object>();

        private BeanFactory() { }        

        /**
         * Положить объект в хранилище
         */
        public void PutBean(String name, Object value)
        {
            beans.Add(name, value);
        }
        /**
         * Взять объект из хранилища
         */
        public Object GetBean(String name)
        {
            return beans[name];
        }
        /**
         * Получить хранилище объектов
         */
        public static BeanFactory GetFactory()
        {
            if (instance == null)
                instance = new BeanFactory();

            return instance;
        }
    }
}
