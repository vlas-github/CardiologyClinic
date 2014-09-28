using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using CardiologyClinic.Help;
using NHibernate;
using NHibernate.Criterion;

namespace CardiologyClinic.Dao
{
    class NurseDaoImpl : NurseDao
    {
        private Connector connector =
            (Connector)BeanFactory.GetFactory().GetBean("connector");

        public void Save(Nurse nurse)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                session.Save(nurse);
                session.Flush();
            }
        }

        public Nurse GetNurseByName(Nurse nurse)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                Console.WriteLine(nurse.Name);
                return (Nurse)session.CreateCriteria(typeof(Nurse))
                    .Add(Expression.Eq("Name", nurse.Name))
                    .UniqueResult();
            }
        }

        public IList<Nurse> GetAllNurse()
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return session.CreateCriteria(typeof(Nurse)).List<Nurse>();
            }
        }

        public User GetNurseByPass(string pass)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return (Nurse)session.CreateCriteria(typeof(Nurse))
                    .Add(Expression.Eq("Password", pass))
                    .UniqueResult();
            }
        }
    }
}
