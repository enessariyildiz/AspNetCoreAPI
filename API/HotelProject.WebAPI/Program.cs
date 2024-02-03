using HotelProject.Business.Abstarct;
using HotelProject.Business.Concrete;
using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IStaffDal, EFStaffDal>();
builder.Services.AddScoped<IStaffService, StaffManager>();
//builder.Services.AddScoped<IRoomDal, EFRoomDal>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
