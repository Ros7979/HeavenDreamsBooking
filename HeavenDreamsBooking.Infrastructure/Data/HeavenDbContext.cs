using HeavenDreamsBooking.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HeavenDreamsBooking.Infrastrucure.Data
{
    public class HeavenDbContext : IdentityDbContext<IdentityUser>
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
               .Entity<DeparturedFlight>()
               .HasOne(df => df.PassengerDetail)
               .WithMany(pd => pd.DeparturedFlights)
               .HasForeignKey(f => f.PassengerDetailsId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<PassengerDetail>()
               .HasOne(pd => pd.RegularFlier)
               .WithOne(pd => pd.PassengerDetail)
               .HasForeignKey<RegularFlier>(r => r.PassengerDetailId)
               .IsRequired();
            
            builder
              .Entity<FlightDetail>()
              .HasOne(r => r.FlightStatus)
              .WithOne(fl => fl.FlightDetail)
              .HasForeignKey<FlightStatus>(r => r.FlightDetailId)
              .IsRequired();

            SeedUsers();
            builder.Entity<IdentityUser>()
                .HasData(BusinessManagerUser, AdminUser, EmployeeUser, user);

            SeedFlights();
            builder.Entity<FlightDetail>()
                .HasData(SOFBCN, SOFLCA, SOFATH,ATHSOF);

            SeedFlightStatus();
            builder.Entity<FlightStatus>()
                .HasData(sofbcnS, soflcaS, sofatnS, atnsofS);

            SeedDiscunts();
            builder.Entity<Discount>()
                .HasData(discountSmall);

            SeedRole();
            builder.Entity<IdentityRole>()
                .HasData(seedRole, seedRoleBM,seedRoleEmplyee, seedRoleClient);

            SeedUserRole();
            builder.Entity<IdentityUserRole<string>>()
                .HasData(userRoleBM, userRoleAdmin, userRoleEmployee, userRoleUser);

            base.OnModelCreating(builder);
        }

        public DbSet<FlightDetail> FlightDetails { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;       
        public DbSet<FlightCanseled> FlightsCanseled { get; set; } = null!;
        public DbSet<FlightStatus> FlightStatus { get; set; } = null!;

        //Second Database For Bussines managers
        public DbSet<DeparturedFlight> DeparturedFlights { get; set; } = null!;
        public DbSet<PassengerDetail> PassengerDetails { get; set; } = null!;
        public DbSet<RegularFlier> RegularFliers { get; set; } = null!;
        public DbSet<Discount> Discounts { get; set; } = null!;

        //Data for seeding Database
        private IdentityUser BusinessManagerUser { get; set; } = null!;
        private IdentityUser AdminUser { get; set; } = null!;
        private IdentityRole seedRole { get; set; } = null!;
        private IdentityRole seedRoleBM { get; set; } = null!;
        private IdentityRole seedRoleEmplyee { get; set; } = null!;
        private IdentityRole seedRoleClient { get; set; } = null!;
        private IdentityUserRole<string> userRoleBM { get; set; } = null!;
        private IdentityUserRole<string> userRoleAdmin { get; set; } = null!;
        private IdentityUserRole<string> userRoleEmployee { get; set; } = null!;
        private IdentityUserRole<string> userRoleUser { get; set; } = null!;
        private IdentityUser EmployeeUser { get; set; } = null!;  
        private IdentityUser user { get; set; } = null!;  
        private FlightDetail SOFBCN { get; set; } = null!;
        private FlightDetail SOFLCA { get; set; } = null!;
        private FlightDetail SOFATH { get; set; } = null!;
        private FlightDetail ATHSOF { get; set; } = null!;
        private FlightStatus sofbcnS { get; set; } = null!;
        private FlightStatus soflcaS { get; set; } = null!;
        private FlightStatus sofatnS { get; set; } = null!;
        private FlightStatus atnsofS { get; set; } = null!;
        private Discount discountSmall { get; set; } = null!;      

        // Seeded Data
        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            BusinessManagerUser = new IdentityUser()
            {
                Id = "bsm12345-b345-s678-m123-b1s2m3456789",
                UserName = "isbusinessmanager@mail.bg",
                NormalizedUserName = "isbusinessmanager@mail.bg",
                Email = "isbusinessmanager@mail.bg",
                NormalizedEmail = "isbusinessmanager@mail.bg",
                EmailConfirmed = true
            };
            BusinessManagerUser.PasswordHash = hasher.HashPassword(BusinessManagerUser, "!123456aA");

            AdminUser = new IdentityUser()
            {
                Id = "adm12345-a345-d678-m321-a3d2m1987654",
                UserName = "pvadminuser@mail.bg",
                NormalizedUserName = "pvadminuser@mail.bg",
                Email = "pvadminuser@mail.bg",
                NormalizedEmail = "pvadminuser@mail.bg",
                EmailConfirmed = true
            };
            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "!123456aA");

            EmployeeUser = new IdentityUser()
            {
                Id = "empu1234-em45-u123-r864-e3m2p1u87652",
                UserName = "spemployuser@mail.bg",
                NormalizedUserName = "spemployuser@mail.bg",
                Email = "spemployuser@mail.bg",
                NormalizedEmail = "spemployuser@mail.bg",
                EmailConfirmed = true
            };
            EmployeeUser.PasswordHash = hasher.HashPassword(EmployeeUser, "!123456aA");
            user = new IdentityUser()
            {
                Id = "user1234-45er-u123-r86s-u3s2e1e87614",
                UserName = "useruser@mail.bg",
                NormalizedUserName = "useruser@mail.bg",
                Email = "useruser@mail.bg",
                NormalizedEmail = "useruser@mail.bg",
                EmailConfirmed = true
            };
            user.PasswordHash = hasher.HashPassword(user, "!123456aA");
        }

        private void SeedRole()
        {
            seedRole = new IdentityRole()
            {
                Id = "1a4b4694-c3d6-4085-8202-56758d2f2925",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
            };
            seedRoleBM = new IdentityRole()
            {
                Id = "bsmrol45-b34a-s67r-m123-b1s2m3r5o7l9",
                Name = "BusinessManager",
                NormalizedName = "BUSINESSMANAGER",
            };
            seedRoleEmplyee = new IdentityRole()
            {
                Id = "e3pu12ro-em45-u1l3-r864-e3m2p1u8r6o2",
                Name = "Employee",
                NormalizedName = "EMPLOYEE",
            };
            seedRoleClient = new IdentityRole()
            {
                Id = "usle1234-45er-o1l3-r8le-u4s2e1e876ro",
                Name = "User",
                NormalizedName = "USER",
            };
        }
        private void SeedUserRole()
        {
            userRoleBM = new IdentityUserRole<string>()
            {
                UserId = "bsm12345-b345-s678-m123-b1s2m3456789",
                RoleId = "bsmrol45-b34a-s67r-m123-b1s2m3r5o7l9"
            };
            userRoleAdmin = new IdentityUserRole<string>()
            {
                UserId = "adm12345-a345-d678-m321-a3d2m1987654",
                RoleId = "1a4b4694-c3d6-4085-8202-56758d2f2925"
            };
            userRoleEmployee = new IdentityUserRole<string>()
            {
                UserId = "empu1234-em45-u123-r864-e3m2p1u87652",
                RoleId = "e3pu12ro-em45-u1l3-r864-e3m2p1u8r6o2"
            };
            userRoleUser = new IdentityUserRole<string>()
            {
                UserId = "user1234-45er-u123-r86s-u3s2e1e87614",
                RoleId = "usle1234-45er-o1l3-r8le-u4s2e1e876ro"
            };
        }

        private void SeedFlightStatus()
        {
            sofbcnS = new FlightStatus()
            {
                Id = 1,
                FltNo = "SOF-BCN",
                DateOfJorney = new DateTime(2024, 08, 23, 14, 35, 00),
                StatusEconomy = 3,
                StatusBusiness = 5,
                WaitListedEconomy = 0,
                WaitListedBusiness = 0,
                FlightDetailId = SOFBCN.Id
            };

            soflcaS = new FlightStatus()
            {
                Id = 2,
                FltNo = "SOF-LCA",
                DateOfJorney = new DateTime(2024, 06, 14, 11, 30, 00),
                StatusEconomy = 4,
                StatusBusiness = 4,
                WaitListedEconomy = 0,
                WaitListedBusiness = 0,
                FlightDetailId = SOFLCA.Id
            };
            sofatnS = new FlightStatus()
            {
                Id = 3,
                FltNo = "SOF-ATH",
                DateOfJorney = new DateTime(2024, 10, 10, 06, 30, 00),
                StatusEconomy = 8,
                StatusBusiness = 10,
                WaitListedEconomy = 0,
                WaitListedBusiness = 0,
                FlightDetailId = SOFATH.Id
            };
            atnsofS = new FlightStatus()
            {
                Id = 4,
                FltNo = "ATH-SOF",
                DateOfJorney = new DateTime(2024, 10, 11, 08, 30, 00),
                StatusEconomy = 8,
                StatusBusiness = 10,
                WaitListedEconomy = 0,
                WaitListedBusiness = 0,
                FlightDetailId = ATHSOF.Id
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
                SeatsBusines = 3,
                SeatsEconomy = 5,
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
                SeatsBusines = 4,
                SeatsEconomy = 4,
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
                ArrTime = new DateTime(2024, 10, 10, 10, 30, 00),
                AircraftType = "Boeing 777",
                SeatsBusines = 8,
                SeatsEconomy = 10,
                FareBusines = 500.00m,
                FareEconomy = 314.00m,
                LaunchDate = DateTime.Now
            };
            ATHSOF = new FlightDetail()
            {
                Id = 4,
                FltNo = "ATH-SOF",
                From = "Атина",
                Destination = "София",
                ImageUrl = "https://th.bing.com/th/id/OIP.gtnO8Z0v_QVMykrG4JUJygHaE8?rs=1&pid=ImgDetMain",
                DepTime = new DateTime(2024, 10, 11, 08, 30, 00),
                ArrTime = new DateTime(2024, 10, 11, 11, 30, 00),
                AircraftType = "Boeing 777",
                SeatsBusines = 8,
                SeatsEconomy = 10,
                FareBusines = 500.00m,
                FareEconomy = 314.00m,
                LaunchDate = DateTime.Now
            };
        }
        private void SeedDiscunts()
        {
            discountSmall = new Discount()
            {
                Id = 1,
                FareLimit = 5500.00m,
                TotalFlightsLimit = 10,
                DiscountGiven = 8.0
            };
        }
    }
}
