using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SysCore.Entities;

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
    
    public class AvailableRoomTypeResponseModel 
    {
     
        public string RoomType { get; set; }
        public int RoomTypeId { get; set; }
        public int Price { get; set; }
        public int Availables { get; set; }
    }
    public class RoomWithCustomer 
    {
     
        public string RoomType { get; set; }
        public int RoomId { get; set; }
        public DateTime? CheckInDates { get; set; }
        public string? CustomerName { get; set; }
        public decimal? TotalBill { get; set; }
        public int? ServiceNumbers { get; set; }
        public int? BookingDays { get; set; }
        
        public List<ServiceResponseModel> ServicesBooked { get; set; }
        
        public class ServiceResponseModel
        {
            public DateTime? ServiceDate;
            public string ServiceDesc;
            public decimal? ServicePrice;
            public int? ServiceId;

        }
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