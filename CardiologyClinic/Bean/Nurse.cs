using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardiologyClinic.Bean
{
    /**
     * Медсестра
     */
    public class Nurse : User
    {
        /**
         * Список комнат, обслужываемых медсестрой
         */
        private ICollection<Room> rooms;

        public ICollection<Room> Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }
    }
}
