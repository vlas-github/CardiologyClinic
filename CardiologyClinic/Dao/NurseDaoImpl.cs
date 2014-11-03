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
                if (nurse.Id == null)
                    session.Save(nurse);
                else
                    session.Update(nurse);
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

        public Nurse GetNurseByRoom(Room room)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return (Nurse)session.CreateCriteria(typeof(Nurse))
                    .CreateCriteria("Rooms")
                    .Add(Expression.Eq("Id", room.Id))
                    .UniqueResult();
            }
        }

        public Nurse GetNurseById(string id)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return (Nurse)session.CreateCriteria(typeof(Nurse))
                    .Add(Expression.Eq("Id", id))
                    .UniqueResult();
            }
        }

        public void DeleteNurse(string id)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                session.Delete((Nurse)session.CreateCriteria(typeof(Nurse))
                    .Add(Expression.Eq("Id", id))
                    .UniqueResult());
                session.Flush();
            }
        }
    }
}
