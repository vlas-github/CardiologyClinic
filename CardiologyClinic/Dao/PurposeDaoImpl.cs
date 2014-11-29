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

        public bool Save(Purpose purpose)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                if (purpose.Id == null)
                {
                    session.Save(purpose);
                }
                else
                {
                    session.Update(purpose);
                }

                session.Flush();
            }

            return true;
        }

        public Purpose GetPurposesById(string id)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return session.CreateCriteria(typeof(Purpose))
                    .Add(Expression.Eq("Id", id))
                    .UniqueResult<Purpose>();
            }
        }

        public IList<Purpose> GetPurposesBetween(DateTime from, DateTime to)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return session.CreateCriteria(typeof(Purpose))
                    .Add(Restrictions.Ge("DateOfProcedure", from))
                    .Add(Restrictions.Lt("DateOfProcedure", to))
                    .List<Purpose>();
            }
        }
    }
}
