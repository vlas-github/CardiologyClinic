using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using NHibernate;
using NHibernate.Criterion;
using CardiologyClinic.Help;

namespace CardiologyClinic.Dao
{
    class PurposeDaoImpl : PurposeDao
    {
        private Connector connector =
            (Connector)BeanFactory.GetFactory().GetBean("connector");

        public ICollection<Purpose> GetPurposesByPatient(Patient p)
        {           
            using (ISession session = connector.GetSession().OpenSession())
            {
                return session.CreateCriteria(typeof(Purpose))
                    .Add(Expression.Eq("Patient", p))
                    .List<Purpose>();
            }
        }

        public void Save(Purpose purpose)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                session.Save(purpose);
                session.Flush();
            }
        }
    }
}
