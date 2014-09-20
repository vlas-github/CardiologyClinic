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
    class DoctorDaoImpl : DoctorDao
    {
        private Connector connector =
            (Connector)BeanFactory.GetFactory().GetBean("connector");

        public void Save(Doctor doctor)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                session.Save(doctor);
                session.Flush();
            }
        }

        public IList<Doctor> GetAllDoctors()
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return session.CreateCriteria(typeof(Doctor)).List<Doctor>();
            }
        }

        public Doctor GetDoctorByName(Doctor doctor)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return (Doctor)session.CreateCriteria(typeof(Doctor))
                    .Add(Expression.Eq("Name", doctor.Name))
                    .UniqueResult();
            }
        }
    }
}
