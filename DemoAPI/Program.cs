using DemoAPI.Common.Data;
using DemoAPI.Repositories;
using DemoAPI.Repositories.Interface;
using DemoAPI.Services;
using DemoAPI.Services.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
builder.Services.AddDbContext<AgendaDbContext>(options =>	options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDemoAPI"))
);
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//	var services = scope.ServiceProvider;
//	var context = services.GetRequiredService<AgendaDbContext>();
//	context.Database.Migrate();
//}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
	endpoints.MapControllers());
app.Run();
