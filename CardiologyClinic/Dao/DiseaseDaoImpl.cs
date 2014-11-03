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
    class DiseaseDaoImpl : DiseaseDao
    {
        private Connector connector =
            (Connector)BeanFactory.GetFactory().GetBean("connector");

        public void Save(Disease disease)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                if (disease.Id == null)
                    session.Save(disease);
                else
                    session.Update(disease);
                session.Flush();
            }
        }

        public IList<Disease> GetAllDiseases()
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return session.CreateCriteria(typeof(Disease)).List<Disease>();
            }
        }

        public Disease GetDiseasByName(Disease disease)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return (Disease)session.CreateCriteria(typeof(Disease))
                    .Add(Expression.Eq("Name", disease.Name))
                    .UniqueResult();
            }
        }

        public Disease GetDiseaseById(string id)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return (Disease)session.CreateCriteria(typeof(Disease))
                    .Add(Expression.Eq("Id", id))
                    .UniqueResult();
            }
        }

        public void DeleteDisease(string id)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                session.Delete((Disease)session.CreateCriteria(typeof(Disease))
                    .Add(Expression.Eq("Id", id))
                    .UniqueResult());
                session.Flush();
            }
        }
    }
}
