using EstateSales.Backend.Context;
using EstateSales.Backend.BackendExtensions;
using EstateSales.Backend.Datas;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<DataContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.ConfigureBackend();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


using(var scope = app.Services.CreateAsyncScope())
{
    var dbContext=scope.ServiceProvider.GetRequiredService<EstateInMemoryContext>();
    dbContext.Database.EnsureCreated();
}
app.UseCors("EstateCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
