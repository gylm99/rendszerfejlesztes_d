using EstateSales.Backend.Context;
using EstateSales.Backend.Repo;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.BackendExtensions
{
    public static class BackendExtensions
    {
        public static void ConfigureCors(this IServiceCollection service)
        {
            service.AddCors(option =>
                option.AddPolicy(name: "EstateSalesCore",
                policy =>
                {
                    policy.WithOrigins("https://localhost:7020/").AllowAnyHeader().AllowAnyMethod();
                }
                )
            );
         
        }

        public static void ConfigureInMemoryContext(this IServiceCollection services) 
        {
            string dbNameInMemoryContext = "Estate" + Guid.NewGuid();
            services.AddDbContext<EstateInMemoryContextcs>(

                options=>options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );
        }

        public static void ConfigureRepos (this IServiceCollection services)
        {
            services.AddScoped<IUserRepo, UserRepo>();
        }
    }
}
