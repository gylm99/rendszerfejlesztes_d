using EstateSales.Backend.Context;
using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo;
using EstateSales.Backend.Repo.Base;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.BackendExtensions
{
    public static class BackendExtensions
    {
        public static void ConfigureBackend(this IServiceCollection services)
        {

            services.AddCors();
            services.ConfigureInMemoryContext();
            services.ConfigureRepos();
        }
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
            services.AddDbContext<EstateInMemoryContext>(

                options=>options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );
        }
        public static void ConfigureRepos (this IServiceCollection services)
        {
            services.AddScoped<IBaseRepo<User>, UserRepo<EstateInMemoryContext>>();
            //services.AddScoped<IUserRepo, UserRepo<EstateInMemoryContext>>();
        }
    }
}
