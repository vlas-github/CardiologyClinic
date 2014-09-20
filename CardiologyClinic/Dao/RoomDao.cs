using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Dao
{
    interface RoomDao
    {
        void Save(Bean.Room room);

        IList<Bean.Room> GetAllRoom();
    }
}
