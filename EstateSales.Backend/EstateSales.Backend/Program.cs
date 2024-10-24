using EstateSales.Backend.Context;
using EstateSales.Backend.BackendExtensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();
builder.Services.ConfigureInMemoryContext();
builder.Services.ConfigureRepos();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


using(var scope = app.Services.CreateAsyncScope())
{
    var dbContext=scope.ServiceProvider.GetRequiredService<EstateInMemoryContextcs>();
    dbContext.Database.EnsureCreated();
}
app.UseCors("EstateCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
