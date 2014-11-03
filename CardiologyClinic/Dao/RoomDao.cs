using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Dao
{
    interface RoomDao
    {
        void Save(Room room);

        IList<Room> GetAllRoom();

        Room GetRoomByNumber(Room room);

        ICollection<Room> GetRoomsByNurse(Nurse nurse);

        Room GetRoomById(string id);
    }
}
