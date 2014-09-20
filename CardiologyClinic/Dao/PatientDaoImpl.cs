using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Help;
using NHibernate;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Dao
{
    class PatientDaoImpl : PatientDao
    {
        private Connector connector =
            (Connector)BeanFactory.GetFactory().GetBean("connector");

        public void Save(Patient patient)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                session.Save(patient);
                session.Flush();
            }
        }

        public IList<Patient> GetAllPatient()
        {
            return null;
        }
    }
}
