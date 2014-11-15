using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Service
{
    interface NurseService
    {
        Room GetRoomByName(Room room);
        Patient GetPatientByName(Patient patient);
        ICollection<Bean.Room> GetRoomsByNurse(Nurse nurse);
        ICollection<Patient> GetPatientByRoom(Room room);
        ICollection<Purpose> GetPurposesByPatient(Patient p);
        Purpose GetPurposesById(string id);
        bool SavePurpose(Purpose p);
    }
}
