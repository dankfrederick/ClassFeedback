using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassFeedback.Modeles
{
    public class Room
    {
        public int RoomID { get; set; }
        public RoomOwner Owner { get; set; }
        public User[] Participants { get; set; }

        /* default constructor creates a new room with an assigned owner and a semi-randomly generated RoomID
         * RoomID will be used for routing and must be unique
         * TODO: Add a check that roomID is unique before assigning
         */
        public Room(RoomOwner _Owner, int ID)
        {   
            Owner = _Owner;
            RoomID = ID;
            Participants = new User[1];
            Participants[0] = _Owner;
        }

    }
}
