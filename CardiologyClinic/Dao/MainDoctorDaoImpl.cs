using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using CardiologyClinic.Help;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Criterion;

namespace CardiologyClinic.Dao
{
    class MainDoctorDaoImpl : MainDoctorDao
    {
        private Connector connector =
            (Connector)BeanFactory.GetFactory().GetBean("connector");

        public User GetMainDoctorByPass(string pass)
        {
            using (ISession session = connector.GetSession().OpenSession())
            return (User)session.
            CreateCriteria(typeof(MainDoctor)).
            Add(Expression.Eq("Password", pass)).
            UniqueResult();
        }
    }
}
