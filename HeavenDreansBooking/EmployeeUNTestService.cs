using HeavenDreamsBooking.Core.Contracts;
using HeavenDreamsBooking.Core.Services.Employee;
using HeavenDreamsBooking.Infrastructure.Data.Models;
using HeavenDreamsBooking.Infrastrucure.Data;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace HeavenDreansBookingTest.UnitTest
{
    [TestFixture]
    public class TesEmployeeUNTestServicets
    {
        private IEnumerable<FlightStatus> flightState;
        private IEnumerable<PassengerDetail> passengerDetails;
        private IEnumerable<Discount> discounts;
        private IEnumerable<RegularFlier> regularFliers;
        private HeavenDbContext dbContext;

        [SetUp]
        public void Setup()
        {
            this.flightState = new List<FlightStatus>()
            {
                new FlightStatus(){Id = 1, FltNo = "SOF-BCN", FlightDetailId = 1, DateOfJorney= DateTime.Parse( "2024-08-23 14:35:00.0000000"), StatusEconomy=0,WaitListedEconomy=2,StatusBusiness=0,WaitListedBusiness=1},
                new FlightStatus(){Id = 2, FltNo = "SOF-LCA", FlightDetailId = 2, DateOfJorney= DateTime.Parse( "2024-08-23 14:35:00.0000000"), StatusEconomy=0,WaitListedEconomy=1,StatusBusiness=0,WaitListedBusiness=2},
               new FlightStatus(){Id = 3, FltNo = "SOF-ATH", FlightDetailId = 3, DateOfJorney= DateTime.Parse( "2024-08-23 14:35:00.0000000"), StatusEconomy=0,WaitListedEconomy=3,StatusBusiness=0,WaitListedBusiness=3}
            };
            var options = new DbContextOptionsBuilder<HeavenDbContext>()
                  .UseInMemoryDatabase(databaseName: "ListedStatusDb") // Give a Unique name to the DB
                  .Options;
            this.dbContext = new HeavenDbContext(options);
            this.dbContext.AddRange(this.flightState);
            this.dbContext.SaveChanges();

            this.passengerDetails = new List<PassengerDetail>()
            {
                new PassengerDetail() {Id=1, Email="useruser@abv.bg", Name="Ivan Ivanov", FareCollected=300.50m, TotalTimesFlown=1},
                new PassengerDetail() {Id=2, Email="pruser@abv.bg", Name="Petar Rusev", FareCollected=50.50m, TotalTimesFlown=1},
                new PassengerDetail() {Id=3, Email="ssuser@abv.bg", Name="Stefan Stefanov", FareCollected=300.00m, TotalTimesFlown=1}
            };
            this.dbContext.AddRange(this.passengerDetails);
            this.dbContext.SaveChanges();

            this.regularFliers = new List<RegularFlier>()
            {
                new RegularFlier() {Id=1, Email="useruser@abv.bg", Discount=0, PassengerDetailId=1},
                new RegularFlier() {Id=2, Email="pruser@abv.bg", Discount=0, PassengerDetailId=2},
                new RegularFlier() {Id=3, Email="ssuser@abv.bg", Discount=0, PassengerDetailId=3}
            };
            this.dbContext.AddRange(this.regularFliers);
            this.dbContext.SaveChanges();

            this.discounts = new List<Discount>()
            {
                new Discount() {Id=1, FareLimit=100m, TotalFlightsLimit=2, DiscountGiven=10}
            };
            this.dbContext.AddRange(this.discounts);
            this.dbContext.SaveChanges();
        }

        [Test]
        public void Test_ChangeWaitListedStatus()
        {
            var flightStatusId = 1;
            var flightStatusId2 = 2;
            string status = "Economy";
            string statusB = "Bussines";
            IEmployeeService service = new EmployeeService(this.dbContext);
            service.ChangeWaitListedStatus(flightStatusId, status);
            var c = this.flightState
                .ToList()
                .Find(d => d.Id == flightStatusId);
            var d = this.flightState
                      .ToList()
                      .Find(d => d.Id == flightStatusId2);
            Assert.True(c != null);
            Assert.True(d != null);
            Assert.True(c?.WaitListedEconomy == 1);
            service.ChangeWaitListedStatus(flightStatusId2, statusB);
            Assert.True(d?.WaitListedBusiness == 1);
            //  Assert.Pass();
        }

        [Test]
        public void Test_FillPassengerDetail()
        {
            string email = "useruser@abv.bg";
            decimal fare = 35.90m;
            IEmployeeService service = new EmployeeService(this.dbContext);
            service.FillPassengerDetail(email, fare);
            var passengerId = this.passengerDetails.ToList().Find(r => r.Email.ToLower().Trim() == email.ToLower().Trim());
            Assert.True(passengerId != null);
            Assert.True(passengerId?.TotalTimesFlown == 2);
        }

        [Test]
        public void Test_CancelChangeFlightStatus()
        {
            var flightStatusId = 1;
            var flightStatusId2 = 2;
            string status = "Economy";
            string statusB = "Bussines";
            IEmployeeService service = new EmployeeService(this.dbContext);
            service.CancelChangeFlightStatus(flightStatusId, status);
            var c = this.flightState
                .ToList()
                .Find(d => d.Id == flightStatusId);
            Assert.True(c != null);
            Assert.True(c.WaitListedEconomy == 1);
            service.CancelChangeFlightStatus(flightStatusId2, statusB);
            var d = this.flightState
                    .ToList()
                    .Find(d => d.Id == flightStatusId2);
            Assert.True(d != null);
            Assert.True(d.WaitListedBusiness == 1);
        }

        //[Test]
        //public void Test_RegularFlierFill()
        //{
        //    var regularFligherId = 1;
        //    var regularFligherId2 = 2;
        //    IEmployeeService service = new EmployeeService(this.dbContext);
        //    service.RegularFlierFill(regularFligherId);
        //    var regFlier = this.regularFliers.FirstOrDefault(d => d.Id == regularFligherId);
        //    var regFlier2 = this.regularFliers.FirstOrDefault(d => d.Id == regularFligherId2);
        //    var discount = this.discounts.FirstOrDefault(d => d.Id == 1);
        //    Assert.True(regFlier != null);
        //    Assert.True(discount != null);
        //    Assert.True(regFlier2 != null);
        //    Assert.True(regFlier?.Discount == discount?.DiscountGiven);
        //    Assert.True(regFlier2?.Discount == 0);
        //}
    }
}