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
        public RoomParticipant[] Participants { get; set; }

        /* default constructor creates a new room with an assigned owner and a semi-randomly generated RoomID
         * RoomID will be used for routing and must be unique
         * TODO: Add a check that roomID is unique before assigning
         */
        public Room(RoomOwner _Owner)
        {   
            Owner = _Owner;
            Random rand = new Random();
            RoomID = Owner.FirstName[0] + Owner.LastName[0] + rand.Next(0, 9999);
        }

    }
}
