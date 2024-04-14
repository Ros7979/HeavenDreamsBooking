using HeavenDreamsBooking.Core.Contracts;
using HeavenDreamsBooking.Core.Services.Employee;
using HeavenDreamsBooking.Infrastructure.Data.Models;
using HeavenDreamsBooking.Infrastrucure.Data;
using Microsoft.EntityFrameworkCore;

namespace HeavenDreansBookingTest.UnitTest
{
    [TestFixture]
    public class TesEmployeeUNTestServicetsAddChange
    {
        private IEnumerable<FlightStatus> flightState;              
        private HeavenDbContext dbContext;

        [SetUp]
        public void Setup()
        {
            this.flightState = new List<FlightStatus>()
            {
                new FlightStatus(){Id = 1, FltNo = "SOF-BCN", FlightDetailId = 1, DateOfJorney= DateTime.Parse( "2024-08-23 14:35:00.0000000"), StatusEconomy=0,WaitListedEconomy=2,StatusBusiness=0,WaitListedBusiness=1},
                new FlightStatus(){Id = 2, FltNo = "SOF-LCA", FlightDetailId = 2, DateOfJorney= DateTime.Parse( "2024-08-23 14:35:00.0000000"), StatusEconomy=1,WaitListedEconomy=1,StatusBusiness=0,WaitListedBusiness=2},
               new FlightStatus(){Id = 3, FltNo = "SOF-ATH", FlightDetailId = 3, DateOfJorney= DateTime.Parse( "2024-08-23 14:35:00.0000000"), StatusEconomy=0,WaitListedEconomy=3,StatusBusiness=0,WaitListedBusiness=3}
            };
            var options = new DbContextOptionsBuilder<HeavenDbContext>()
                  .UseInMemoryDatabase(databaseName: "ListedStatusDb") // Give a Unique name to the DB
                  .Options;
            this.dbContext = new HeavenDbContext(options);
            this.dbContext.AddRange(this.flightState);
            this.dbContext.SaveChanges();                   
        } 

        [Test]
        public void Test_AddChangeFlightStatus()
        {
            var flightStatusId = 1;
            var flightStatusId2 = 2;            
            string status = "Economy";
            string statusB = "Bussines";
            IEmployeeService service = new EmployeeService(this.dbContext);
            service.AddChangeFlightStatus(flightStatusId, status);
            var changeFlight = this.flightState.ToList().Find(r => r.Id == flightStatusId);
            Assert.True(changeFlight != null);
            Assert.True(changeFlight?.WaitListedEconomy == 3);
            service.AddChangeFlightStatus(flightStatusId2, status);
            var changeFlight2 = this.flightState.ToList().Find(r => r.Id == flightStatusId2);
            Assert.True(changeFlight2 != null);
            Assert.True(changeFlight2?.StatusEconomy == 0);
            service.AddChangeFlightStatus(flightStatusId2, statusB);
            var changeFlight3 = this.flightState.ToList().Find(r => r.Id == flightStatusId2);
            Assert.True(changeFlight3 != null);
            Assert.True(changeFlight3?.StatusEconomy == 0);
        }
    }
}