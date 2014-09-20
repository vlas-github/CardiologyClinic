using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Help;
using CardiologyClinic.Bean;
using NHibernate;

namespace CardiologyClinic.Dao
{
    class RoomDaoImpl : RoomDao
    {
        private Connector connector =
            (Connector)BeanFactory.GetFactory().GetBean("connector");

        public void Save(Room room)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                session.Save(room);
                session.Flush();
            }
        }

        public IList<Room> GetAllRoom()
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return session.CreateCriteria(typeof(Room)).List<Room>();
            }
        }
    }
}
