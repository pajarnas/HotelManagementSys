using System;
using System.Collections.Generic;

namespace SysCore.Entities
{
    public class Service
    {
        public int Id { get; set; }
        
        public int RoomId { get; set; }
        
        public DateTime? ServiceDate { get; set; }

        public ServiceType ServiceType { get; set; }

        public int ServiceTypeId { get; set; }

        public Room Room { get; set; }
    }
}