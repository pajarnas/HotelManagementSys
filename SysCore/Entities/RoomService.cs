using System.Collections.Generic;

namespace SysCore.Entities
{
    public class RoomService
    {
        public int RoomId { get; set; }
        public int ServiceId { get; set; }
        public Room Room { get; set; }
        public Service Service { get; set; }
    }
}
 