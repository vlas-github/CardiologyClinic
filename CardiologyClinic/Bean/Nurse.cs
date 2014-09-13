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
        private IList<Room> rooms;

        public IList<Room> Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }
    }
}
