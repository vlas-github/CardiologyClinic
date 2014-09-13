using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Service
{
    interface LoginService
    {
        User GetPatientByPass(String pass);

        User GetDoctorByPass(string pass);

        User GetNurseByPass(string pass);

        User GetMainDoctorByPass(string pass);
    }
}
