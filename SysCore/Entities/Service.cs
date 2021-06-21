using System;
using System.Collections.Generic;

namespace SysCore.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string SDesc { get; set; }
        public decimal? Amount { get; set; }
        
        public DateTime? ServiceDate { get; set; }
        
        public ICollection<RoomService> RoomServices { get; set; }
        
        
    }
}