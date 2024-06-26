﻿using HeavenDreamsBooking.Core.Contracts;
using HeavenDreamsBooking.Core.Services.Employee;
using HeavenDreamsBooking.Core.Services.Flight;
using HeavenDreamsBooking.Core.Services.Reservation;
using HeavenDreamsBooking.Infrastrucure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IFlightService, FlightService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<HeavenDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();
            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            })
            .AddEntityFrameworkStores<HeavenDbContext>();
            return services;
        }
    }
}
