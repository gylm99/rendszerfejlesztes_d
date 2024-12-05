using EstateSales.Backend.Context;
using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo;
using EstateSales.Backend.Repo.Base;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.BackendExtensions
{
    public static class BackendExtensions
    {

        //Fő program
        public static void ConfigureBackend(this IServiceCollection services)
        {

            services.ConfigureCors();
            services.ConfigureInMemoryContext();
            services.ConfigureMysqLContext();
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

        public static void ConfigureMysqLContext(this IServiceCollection service)
        {
            string connectionString = "server=localhost;userid=root;password=;database=real_estate_sale_db;port=3306";
            service.AddDbContext<EstateMySqlContext>(options => options.UseMySQL(connectionString));
        }

        public static void ConfigurMysqlIdentityContext(this IServiceCollection services)
        {
            string connectionString = "server=localhost;userid=root;password=;database=real_estate_sale_db;port=3306";
            services.AddDbContext<EstateMySqlIdentityContext>(options => options.UseMySQL(connectionString));
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
            bool test=true;
            if (test)
            {
                services.AddScoped<IBaseRepo<User>, UserRepo<EstateInMemoryContext>>();
                services.AddScoped<IBaseRepo<Advertisement>, AdvertisementRepo<EstateInMemoryContext>>();
                services.AddScoped<IBaseRepo<Message>, MessageRepo<EstateInMemoryContext>>();
                services.AddScoped<IPhotoRepo, PhotoRepo<EstateInMemoryContext>>();
                services.AddScoped<IAdvertisementRepo, AdvertisementRepo<EstateInMemoryContext>>();
                services.AddScoped<IMessageRepo, MessageRepo<EstateInMemoryContext>>();

                //services.AddScoped<IUserRepo, UserRepo<EstateInMemoryContext>>();
            }
            else
            {
                services.AddScoped<IBaseRepo<User>, UserRepo<EstateMySqlContext>>();
                services.AddScoped<IBaseRepo<Advertisement>, AdvertisementRepo<EstateMySqlContext>>();
                services.AddScoped<IBaseRepo<Message>,MessageRepo<EstateMySqlContext>>();
                services.AddScoped<IPhotoRepo,PhotoRepo<EstateMySqlContext>>();
                services.AddScoped<IAdvertisementRepo, AdvertisementRepo<EstateMySqlContext>>();
                services.AddScoped<IMessageRepo, MessageRepo<EstateMySqlContext>>();

            }
        }
    }
}
