using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Help;
using NHibernate;
using CardiologyClinic.Bean;

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
                session.Save(medicalProcedure);
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
    }
}
