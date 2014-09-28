using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Help;
using NHibernate;
using CardiologyClinic.Bean;
using NHibernate.Criterion;

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
            using (ISession session = connector.GetSession().OpenSession())
            {
                return session.CreateCriteria(typeof(Patient)).List<Patient>();
            }
        }

        public User GetPatientByPass(string pass)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return (Patient)session.CreateCriteria(typeof(Patient))
                    .Add(Expression.Eq("Password", pass))
                    .UniqueResult();
            }
        }
    }
}
