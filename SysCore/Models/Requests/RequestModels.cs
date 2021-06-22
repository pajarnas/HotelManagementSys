using System;
using SysCore.Entities;

namespace SysCore.Models.Requests
{
    public class RequestModels
    {
        
    }
  
    public class BookRequest
    {
            
        public int? roomNo { get; set; }
        public string cName { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime? checkin { get; set; }
        public int? totalPersons { get; set; }
        public int? bookingDays { get; set; }
        public decimal? avance { get; set; }
            
    }
}