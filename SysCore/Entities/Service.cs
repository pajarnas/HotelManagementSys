using System;

namespace SysCore.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public int? RoomNo { get; set; }
        public string SDesc { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? ServiceDate { get; set; }
        public Room Room { get; set; }
        
    }
}