using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
namespace CardiologyClinic.Help
{
    interface Connector
    {
        ISessionFactory GetSession();
    }
}
