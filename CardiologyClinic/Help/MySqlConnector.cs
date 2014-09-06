using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace CardiologyClinic.Help
{
    class MySqlConnector : Connector
    {
        private static MySqlConnector instance;

        private ISessionFactory sessions;

        private void Configure()
        {
            sessions = new Configuration().Configure()
                .AddClass(typeof(Patient))
                .AddClass(typeof(Doctor))
                .AddClass(typeof(Nurse))
                .AddClass(typeof(MainDoctor))
                .AddClass(typeof(Room))
                .AddClass(typeof(Purpose))
                .AddClass(typeof(Disease))
                .AddClass(typeof(MedicalProcedure))
                .BuildSessionFactory();
        }

        private MySqlConnector() { }

        public static Connector GetInstance() 
        {
            if (instance == null)
            {
                instance = new MySqlConnector();
                instance.Configure();
            }

            return instance;
        }

        public ISessionFactory GetSessionFactory()
        {
            return sessions;
        }

        public void CreateTables()
        {
            Configuration configuration = new Configuration();
            configuration.Configure();

            configuration.AddClass(typeof(Patient));
            configuration.AddClass(typeof(Doctor));
            configuration.AddClass(typeof(Nurse));
            configuration.AddClass(typeof(MainDoctor));
            configuration.AddClass(typeof(Room));
            configuration.AddClass(typeof(Purpose));
            configuration.AddClass(typeof(Disease));
            configuration.AddClass(typeof(MedicalProcedure));

            SchemaExport schemaExport = new SchemaExport(configuration);

            schemaExport.Execute(false, true, false);
        }
    }
}
