using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SweatSmart.UserService.Persistence.Data;
using SweatSmart.UserService.Persistence.Interfaces;
using SweatSmart.UserService.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweatSmart.UserService.Persistence
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserDbContext>(opts => opts.UseSqlServer(configuration["ConnectionString:UserServiceConnection"]));
            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }

    }
}
