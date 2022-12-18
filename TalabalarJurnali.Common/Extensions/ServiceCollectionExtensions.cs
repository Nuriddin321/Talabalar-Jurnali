using Microsoft.EntityFrameworkCore;
using TalabalarJurnali.Data.Data;
using TalabalarJurnali.Data.Entities;

namespace TalabalarJurnali.Common.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAppDbContext(this IServiceCollection collection, ConfigurationManager configuration)
        {
            collection.AddDbContext<AppDbContext>(options =>
            {
                options.UseLazyLoadingProxies().UseSqlite(configuration.GetConnectionString("localhost"));
            });
        }

        public static void AddIdentityManagers(this IServiceCollection collection)
        {
            collection.AddIdentity<AppUser, AppUserRole>(options =>
                {
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequiredLength = 6;
                    options.Password.RequireUppercase = false;
                })
                .AddEntityFrameworkStores<AppDbContext>();
        }

        public static void AddCorsPolicy(this IServiceCollection collection, ConfigurationManager configuration)
        {
            collection.AddCors(options =>
            {
                options.AddDefaultPolicy(cors =>
                {
                    cors.WithOrigins(configuration["AllowedOrigins"])
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials();
                });
            });
        }
    }
}
