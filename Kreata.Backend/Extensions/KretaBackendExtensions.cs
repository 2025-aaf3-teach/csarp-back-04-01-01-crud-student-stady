
using Microsoft.EntityFrameworkCore;
using MyApp.Backend.Context;

namespace Kreata.Backend.Extensions
{
    public static class KretaBackendExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {

            services.AddCors(option =>
                 option.AddPolicy(name: "KretaCors",
                     policy =>
                     {
                         policy.WithOrigins("https://localhost:7090/")
                         .AllowAnyHeader()
                         .AllowAnyMethod();
                     }
                 )
            );
        }

        public static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbNameKretaContext = "Kreta" + Guid.NewGuid();
            services.AddDbContext<AppInMemoryDbContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameKretaContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );

        }

    }
}
