using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SysCore.Entities;
using SysCore.Models.Requests;
using SysCore.Models.Responses;
using SysCore.ServiceInterfaces;
using SysCore.RepositoryInterfaces;
namespace SysInfrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;
        private readonly IRoomRepo _roomRepo;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepo customerRepo,IMapper mapper,IRoomRepo roomRepo)
        {
            _customerRepo = customerRepo;
            _mapper = mapper;
            _roomRepo = roomRepo;
        }
        public async Task<List<CustomerDetailResponseModel>> GetCustomerDetailResponse()
        {
            var entities = await _customerRepo.ListAllAsync();
            var models = _mapper.Map<List<CustomerDetailResponseModel>>(entities);
            return  models;
        }

        public async Task<List<CustomerResponseModel>> GetCustomerResponse()
        {
            var entities = await _customerRepo.ListAllAsync();
            var models = _mapper.Map<List<CustomerResponseModel>>(entities);
            return  models;
        }

        public async Task<bool> BookRoomForUser(BookRequest bookRequest)
        {
            Customer c = new Customer
            {
                Address = bookRequest.address,
                CName = bookRequest.cName,
                RoomNo = bookRequest.roomNo,
                Phone = bookRequest.phone,
                Email = bookRequest.email,
                Checkin = bookRequest.checkin,
                TotalPersons = bookRequest.totalPersons,
                BookingDays = bookRequest.bookingDays,
                Advance = bookRequest.advance
            };
            var r = await _roomRepo.GetByIdAsync(bookRequest.roomNo.Value);
            r.Status = !r.Status;
            await _roomRepo.UpdateAsync(r);
            await _customerRepo.AddAsync(c);
            return true;

        }
            
        public async Task<bool> DeleteBook(int id)
        {
            var room = await _roomRepo.GetByIdWithIncludesAsync(include:m=>m.Include(m=>m.Customer).Include(m=>m.Services),filter:m=>m.Id==id);
            var c = room.Customer;
            await _customerRepo.DeleteAsync(c);
          
            room.Status = false;
            if(room.Services.Any())
                room.Services.Clear();
            await _roomRepo.UpdateAsync(room);
            
            return true;
        }
    }
}