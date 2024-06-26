﻿using HeavenDreamsBooking.Core.Contracts;
using HeavenDreamsBooking.Infrastrucure.Data;
using Microsoft.EntityFrameworkCore;
namespace HeavenDreamsBooking.Core.Services.Employee

{
    public class EmployeeService : IEmployeeService
    {
        private readonly HeavenDbContext _context;
        public EmployeeService(HeavenDbContext context)
        {
            _context = context;
        }

        public void AddChangeFlightStatus(int id, string status)
        {
            var flightStatusRead = _context.FlightStatus.FirstOrDefault(f => f.FlightDetailId == id);
            if (flightStatusRead != null)
            {
                if (status.ToLower().Trim() == "economy")
                {
                    try
                    {
                        if (flightStatusRead.StatusEconomy <= 0)
                        {
                            flightStatusRead.WaitListedEconomy += 1;
                            _context.SaveChanges();
                        }
                        else if (flightStatusRead.StatusEconomy > 0)
                        {
                            flightStatusRead.StatusEconomy -= 1;
                            _context.SaveChanges();
                        }
                    }
                    catch (Exception ex) { }
                }
                else
                {
                    try
                    {
                        if (flightStatusRead.StatusBusiness <= 0)
                        {
                            flightStatusRead.WaitListedBusiness += 1;
                            _context.SaveChanges();
                        }
                        else if (flightStatusRead.StatusBusiness > 0)
                        {
                            flightStatusRead.StatusBusiness -= 1;
                            _context.SaveChanges();
                        }
                    }
                    catch (Exception ex) { }
                }
            }

        }

        public void FillPassengerDetail(string email, decimal fare)
        {
            var passengerId = _context.PassengerDetails.SingleOrDefault(r => r.Email.ToLower().Trim() == email.ToLower().Trim());
            if (passengerId != null)
            {
                passengerId.TotalTimesFlown += 1;
                passengerId.FareCollected += fare;
                try
                {
                    _context.SaveChangesAsync();
                }
                catch { DbUpdateConcurrencyException due; }
                {  }               
                var regularFlier = _context.RegularFliers.Find(passengerId.Id);                
                var discountSetSmall = _context.Discounts.Find(1);
                if (passengerId?.FareCollected > discountSetSmall?.FareLimit | (passengerId?.TotalTimesFlown > discountSetSmall?.TotalFlightsLimit))
                {
                    regularFlier!.Discount = discountSetSmall!.DiscountGiven;
                    try
                    {
                        _context.SaveChangesAsync();
                    }
                    catch { DbUpdateConcurrencyException due; }
                    { }
                }
            }
        }

        public void CancelChangeFlightStatus(int id, string status)
        {
            var flightStatusRead = _context.FlightStatus.Find(id);
            if (flightStatusRead != null)
            {
                if (status.ToLower().Trim() == "economy")
                {                    
                    if (flightStatusRead.WaitListedEconomy > 0)
                    {
                        flightStatusRead.WaitListedEconomy -= 1;
                        _context.SaveChanges();
                    }
                    else
                    {
                        flightStatusRead.StatusEconomy += 1;
                        _context.SaveChanges();
                    }
                }
                else
                {                    
                    if (flightStatusRead.WaitListedBusiness > 0)
                    {
                        flightStatusRead.WaitListedBusiness -= 1;
                        _context.SaveChanges();
                    }
                    else
                    {
                        flightStatusRead.StatusBusiness += 1;
                        _context.SaveChanges();
                    }
                }
            }
        }
        public void ChangeWaitListedStatus(int id, string status)
        {
            var flightStatusRead = _context.FlightStatus.FirstOrDefault(f => f.FlightDetailId == id);
            if (flightStatusRead != null)
            {
                if (status.ToLower().Trim() == "economy")
                {
                    flightStatusRead.WaitListedEconomy -= 1;
                }
                else
                {
                    flightStatusRead.WaitListedBusiness -= 1;
                }
                try
                {
                    _context.SaveChanges();
                }
                catch { DbUpdateConcurrencyException due; }
            }
        }
    }
}
