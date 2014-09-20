using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using CardiologyClinic.Help;
using NHibernate;

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
    }
}
