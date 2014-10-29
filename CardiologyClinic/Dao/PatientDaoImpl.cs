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
    class PatientDaoImpl : PatientDao
    {
        private Connector connector =
            (Connector)BeanFactory.GetFactory().GetBean("connector");

        public void Save(Patient patient)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                if (patient.Id == null)
                    session.Save(patient);
                else
                    session.Update(patient);
                session.Flush();
            }
        }

        public IList<Patient> GetAllPatient()
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return session.CreateCriteria(typeof(Patient)).List<Patient>();
            }
        }

        public User GetPatientByPass(string pass)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return (Patient)session.CreateCriteria(typeof(Patient))
                    .Add(Expression.Eq("Password", pass))
                    .UniqueResult();
            }
        }

        public IList<Patient> GetPatientByDoctor(User user)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return session.CreateCriteria(typeof(Patient))
                    .Add(Expression.Eq("Doctor", user))
                    .List<Patient>();
            }
        }

        public void GetPatientByName(Patient patient)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                Patient tmp = (Patient)session.CreateCriteria(typeof(Patient))
                    .Add(Expression.Eq("Name", patient.Name))
                    .UniqueResult();

                patient.Id = tmp.Id;
                patient.Name = tmp.Name;
                patient.Password = tmp.Password;
                patient.Purposes = tmp.Purposes;
                patient.Room = tmp.Room;
            }
        }

        public Patient GetPatientById(string id)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return (Patient)session.CreateCriteria(typeof(Patient))
                    .Add(Expression.Eq("Id", id))
                    .UniqueResult();
            }
        }

        public ICollection<Patient> GetPatientsByRoom(Room room)
        {
            using (ISession session = connector.GetSession().OpenSession())
            {
                return session.CreateCriteria(typeof(Patient))
                    .Add(Expression.Eq("Room", room))
                    .List<Patient>();
            }
        }
    }
}
