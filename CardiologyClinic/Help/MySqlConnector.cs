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
        private ISessionFactory sessions;

        public void Configure()
        {
            sessions = new Configuration().Configure()
                .AddFile("Mapping\\Patient.hbm.xml")
                .AddFile("Mapping\\Doctor.hbm.xml")
                .AddFile("Mapping\\Nurse.hbm.xml")
                .AddFile("Mapping\\MainDoctor.hbm.xml")
                .AddFile("Mapping\\Room.hbm.xml")
                .AddFile("Mapping\\Purpose.hbm.xml")
                .AddFile("Mapping\\Disease.hbm.xml")
                .AddFile("Mapping\\MedicalProcedure.hbm.xml")
                .BuildSessionFactory();
        }

        public MySqlConnector() { }

        public ISessionFactory GetSession()
        {
            return sessions;
        }

        public void CreateTables()
        {
            Configuration configuration = new Configuration();
            configuration.Configure();

            configuration.AddFile("Mapping\\Patient.hbm.xml");
            configuration.AddFile("Mapping\\Doctor.hbm.xml");
            configuration.AddFile("Mapping\\Nurse.hbm.xml");
            configuration.AddFile("Mapping\\MainDoctor.hbm.xml");
            configuration.AddFile("Mapping\\Room.hbm.xml");
            configuration.AddFile("Mapping\\Purpose.hbm.xml");
            configuration.AddFile("Mapping\\Disease.hbm.xml");
            configuration.AddFile("Mapping\\MedicalProcedure.hbm.xml");

            SchemaExport schemaExport = new SchemaExport(configuration);
            schemaExport.Execute(false, true, false);
        }
    }
}
