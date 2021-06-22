using System;

namespace SysCore.Models.Responses
{
    public class ResponseModels
    {
        
    }

    public class CustomerDetailResponseModel: CustomerResponseModel
    {
 
        public DateTime? Checkin { get; set; }
        public int? TotalPersons { get; set; }
        public int? BookingDays { get; set; }
        public decimal? Advance { get; set; }
    }
    
    public class RoomTypesResponseModel
    {
        public int Id { get; set; }
        public string RtDesc { get; set; }
        public decimal? Rent { get; set; }    
    }
    
    public class ServiceResponseModel
    {
        
    }
    
    public class RoomResponseModel
    {
        public int Id { get; set; }
        public string RoomType { get; set; }
        public bool Status { get; set; }
        public int RoomTypeId { get; set; }
        public int Price { get; set; }
    }

    public class RoomDetailResponseModel
    {
        
    }

    public class CustomerResponseModel
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }
        public string CName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
    
    
}