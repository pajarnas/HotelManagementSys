using System;
using System.Collections.Generic;
using System.Text;
 

namespace SysCore.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int? RtCode { get; set; }
        public bool? Status { get; set; }
        public RoomType RoomType { get; set; }
        public Customer Customer { get; set; }
        
      
       public ICollection<Service> Services { get; set; }
    }
}


