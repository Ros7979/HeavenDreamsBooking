using HeavenDreamsBooking.Core.Contracts;
using HeavenDreamsBooking.Core.Services.Employee;
using HeavenDreamsBooking.Core.Services.Reservation;
using HeavenDreamsBooking.Infrastructure.Data.Models;
using HeavenDreamsBooking.Infrastrucure.Data;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
namespace HeavenDreansBookingTest.UnitTest
{
    [TestFixture]
    internal class ReservationServiceUNTest
    {
        private IEnumerable<Reservation> reservations;
        private HeavenDbContext dbContext;

        [Test]
        public void Setup()
        {
            this.reservations = new List<Reservation>()
            {
                new Reservation(){Id = 1, FltNo = "SOF-BCN", FlightDetailsId = 1, DateOfJorney= DateTime.Parse( "2024-08-23 14:35:00.0000000"), ClassOfRes="Economy",Name="Ivan",Email="user@abv.bg",Fare=234.0m, Status="Confirmed", UserId="ajsja-122", DateOfRes=DateTime.Now, TicketConfirmed=true},
                new Reservation(){Id = 2, FltNo = "SOF-BCL", FlightDetailsId = 2, DateOfJorney= DateTime.Parse( "2024-09-23 14:35:00.0000000"), ClassOfRes="Business",Name="Ivan",Email="user@abv.bg",Fare=264.0m, Status="Not confirmed", UserId="ammm-122", DateOfRes=DateTime.Now, TicketConfirmed=false}

            };
            var options = new DbContextOptionsBuilder<HeavenDbContext>()
                  .UseInMemoryDatabase(databaseName: "ListedStatusDb") // Give a Unique name to the DB
                  .Options;
            this.dbContext = new HeavenDbContext(options);
            this.dbContext.AddRange(this.reservations);
            this.dbContext.SaveChanges();
        }

        [Test]
        public void Test_ReservationClientDetails()
        {
            string id = "ajsja-122";
            IReservationService service = new ReservationService(this.dbContext);
            var gh= service.ReservationClientDetails(id).FirstOrDefault(f=>f.UserId==id);           
            Assert.IsNotNull(gh);
            Assert.True(gh.Id == 1);
        }

    }
}
