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
    class MedicalProcedureDaoImpl : MedicalProcedureDao
    {
        private Connector connector =
            (Connector)BeanFactory.GetFactory().GetBean("connector");

        public void Save(MedicalProcedure medicalProcedure)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                if (medicalProcedure.Id == null)
                    session.Save(medicalProcedure);
                else
                    session.Update(medicalProcedure);
                session.Flush();
            }
        }

        public IList<MedicalProcedure> GetAllMedicalProcedures()
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return session.CreateCriteria(typeof(MedicalProcedure)).List<MedicalProcedure>();
            }
        }

        public MedicalProcedure GetMedicalProcedureById(string id)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return (MedicalProcedure)session.CreateCriteria(typeof(MedicalProcedure))
                    .Add(Expression.Eq("Id", id))
                    .UniqueResult();
            }
        }

        public MedicalProcedure GetMedicalProcedureByName(string p)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return (MedicalProcedure)session.CreateCriteria(typeof(MedicalProcedure))
                    .Add(Expression.Eq("Name", p))
                    .UniqueResult();
            }
        }
    }
}
