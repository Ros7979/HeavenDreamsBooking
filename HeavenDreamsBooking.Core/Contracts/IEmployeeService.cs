using HeavenDreamsBooking.Infrastructure.Data.Models;

namespace HeavenDreamsBooking.Core.Contracts
{
    public interface IEmployeeService
    {
        public void AddChangeFlightStatus(int id, string status);
        public void FillPassengerDetail(string email, decimal fare);
        public void RegularFlierFill(int id);
        public void CancelChangeFlightStatus(int id, string status);
        public void ChangeWaitListedStatus(int id, string status);
    }
}
