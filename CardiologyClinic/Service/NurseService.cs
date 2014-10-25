using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Service
{
    interface NurseService
    {
        void GetRoomByName(Bean.Room room);
        void GetPatientByName(Bean.Patient patient);
    }
}
