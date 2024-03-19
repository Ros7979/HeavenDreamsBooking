using HeavenDreamsBooking.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HeavenDreamsBooking.Infrastrucure.Data
{
    public class HeavenDbContext : IdentityDbContext
    {
        public HeavenDbContext(DbContextOptions<HeavenDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Reservation>()
                .HasOne(r => r.FlightDetail)
                .WithMany(fl => fl.Reservations)
                .HasForeignKey(r => r.FlightDetailsId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<Reservation>()
               .HasOne(r => r.ProcessedBy)
               .WithMany()
               .HasForeignKey(r => r.FlightDetailsId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
             .Entity<FlightCanseled>()
             .HasOne(fc => fc.ProcessedBy)
             .WithMany()
             .HasForeignKey(fc => fc.ProcessedById)
             .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<DeparturedFlight>()
               .HasOne(df => df.PassengerDetail)
               .WithMany(pd => pd.DeparturedFlights)
               .HasForeignKey(f => f.PassengerDetailId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<PassengerDetail>()
               .HasOne(pd => pd.RegularFlier)
               .WithOne(pd => pd.PassengerDetail)
               .HasForeignKey<RegularFlier>(r => r.PassengerDetailId)
               .IsRequired();
            //In case of use of Status table
            //builder
            //   .Entity<FlightStatus>()
            //   .HasOne(r => r.FlightDetail)
            //   .WithMany(fl => fl.FlightStatuses)
            //   .HasForeignKey(r => r.FlightDetailId)
            //   .OnDelete(DeleteBehavior.Restrict);

            SeedUsers();
            builder.Entity<IdentityUser>()
                .HasData(BusinessManagerUser, AdminUser, EmployeeUser);

            SeedProcessedBy();
            builder.Entity<ProcessedBy>()
                .HasData(BusinessManager, Administrator, Employee);

            SeedFlights();
            builder.Entity<FlightDetail>()
                .HasData(SOFBCN, SOFLCA, SOFATH);

            SeedRole();
            builder.Entity<IdentityRole>()
                .HasData(seedRole);

            base.OnModelCreating(builder);
        }

        public DbSet<FlightDetail> FlightDetails { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;
        public DbSet<ProcessedBy> ProcessedBies { get; set; } = null!;
        public DbSet<FlightCanseled> FlightsCanseled { get; set; } = null!;
        //public DbSet<FlightStatus> FlightStatus { get; set; } = null!;

        //Second Database For Bussines managers
        public DbSet<DeparturedFlight> DeparturedFlights { get; set; } = null!;
        public DbSet<PassengerDetail> PassengerDetails { get; set; } = null!;
        public DbSet<RegularFlier> RegularFliers { get; set; } = null!;


        //Data for seeding Database
        private IdentityUser BusinessManagerUser { get; set; } = null!;
        private IdentityUser AdminUser { get; set; } = null!;
        private IdentityRole seedRole { get; set; } = null!;
        private IdentityUser EmployeeUser { get; set; } = null!;
        private ProcessedBy BusinessManager { get; set; } = null!;
        private ProcessedBy Administrator { get; set; } = null!;
        private ProcessedBy Employee { get; set; } = null!;
        private FlightDetail SOFBCN { get; set; } = null!;
        private FlightDetail SOFLCA { get; set; } = null!;
        private FlightDetail SOFATH { get; set; } = null!;

        // Seeded Data
        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            BusinessManagerUser = new IdentityUser()
            {
                Id = "bsm12345-b345-s678-m123-b1s2m3456789",
                UserName = "Ivan Stamenov",
                NormalizedUserName = "Ivan Stamenov",
                Email = "isbusinessmanager@mail.bg",
                NormalizedEmail = "isbusinessmanager@mail.bg"
            };
            BusinessManagerUser.PasswordHash = hasher.HashPassword(BusinessManagerUser, "bsm456");

            AdminUser = new IdentityUser()
            {
                Id = "adm12345-a345-d678-m321-a3d2m1987654",
                UserName = "Petar Vasilev",
                NormalizedUserName = "Petar Vasilev",
                Email = "pvadminuser@mail.bg",
                NormalizedEmail = "isadminuser@mail.bg"
            };

            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "admin123");

            EmployeeUser = new IdentityUser()
            {
                Id = "empu1234-em45-u123-r864-e3m2p1u87652",
                UserName = "Svetla Peteva",
                NormalizedUserName = "Svetla Peteva",
                Email = "spemployuser@mail.bg",
                NormalizedEmail = "spemployuser@mail.bg"
            };

            EmployeeUser.PasswordHash = hasher.HashPassword(EmployeeUser, "empl3user56");
        }

        private void SeedRole()
        {
            seedRole = new IdentityRole()
            {
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
            };
        }
        private void SeedProcessedBy()
        {
            BusinessManager = new ProcessedBy()
            {
                Id = 1,
                PhoneNumber = "+359878907060",
                UserId = BusinessManagerUser.Id,
            };
            Administrator = new ProcessedBy()
            {
                Id = 2,
                PhoneNumber = "+359778204906",
                UserId = AdminUser.Id,
            };
            Employee = new ProcessedBy()
            {
                Id = 3,
                PhoneNumber = "+359778204906",
                UserId = EmployeeUser.Id,
            };
        }
        private void SeedFlights()
        {
            SOFBCN = new FlightDetail()
            {
                Id = 1,
                FltNo = "SOF-BCN",
                From = "София",
                Destination = "Барселона",
                ImageUrl = "https://wallpaperaccess.com/full/1322174.jpg",
                DepTime = new DateTime(2024, 08, 23, 14, 35, 00),
                ArrTime = new DateTime(2024, 08, 24, 10, 35, 00),
                AircraftType = "Airbus a380",
                SeatsBusines = 30,
                SeatsEconomy = 50,
                FareBusines = 180.00m,
                FareEconomy = 125.40m,
                LaunchDate = DateTime.Now
            };
            SOFLCA = new FlightDetail()
            {
                Id = 2,
                FltNo = "SOF-LCA",
                From = "София",
                Destination = "Ларнака",
                ImageUrl = "https://www.goatsontheroad.com/wp-content/uploads/2022/11/Malindi-Beach-in-Limassol.jpeg",
                DepTime = new DateTime(2024, 06, 14, 11, 30, 00),
                ArrTime = new DateTime(2024, 06, 14, 16, 22, 00),
                AircraftType = "Airbus a320",
                SeatsBusines = 24,
                SeatsEconomy = 40,
                FareBusines = 280.00m,
                FareEconomy = 200.00m,
                LaunchDate = DateTime.Now
            };
            SOFATH = new FlightDetail()
            {
                Id = 3,
                FltNo = "SOF-ATH",
                From = "София",
                Destination = "Атина",
                ImageUrl = "https://th.bing.com/th/id/OIP.gtnO8Z0v_QVMykrG4JUJygHaE8?rs=1&pid=ImgDetMain",
                DepTime = new DateTime(2024, 10, 10, 06, 30, 00),
                ArrTime = new DateTime(2024, 10, 10, 23, 30, 00),
                AircraftType = "Boeing 747",
                SeatsBusines = 4,
                SeatsEconomy = 80,
                FareBusines = 500.00m,
                FareEconomy = 314.00m,
                LaunchDate = DateTime.Now
            };
        }

    }

}
