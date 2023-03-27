using Microsoft.EntityFrameworkCore;
using Office_Seat_Booking_BLL.Services;
using Office_Seat_Booking_DLL;
using Office_Seat_Booking_DLL.Repost;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.var builder = WebApplication.CreateBuilder(args);



// Add services to the container.



builder.Services.AddControllers();



builder.Services.AddScoped<IEmployeeRepost, EmployeeRepost>();
builder.Services.AddScoped<EmployeeService, EmployeeService>();

builder.Services.AddScoped<IBookingRepost, BookingRepost>();
builder.Services.AddScoped<BookingService, BookingService>();

builder.Services.AddScoped<IFloorRepost, FloorRepost>();
builder.Services.AddScoped<FloorService, FloorService>();

builder.Services.AddScoped<IParkingRepost, ParkingRepost>();
builder.Services.AddScoped<ParkingService, ParkingService>();

builder.Services.AddScoped<ISeatRepost, SeatRepost>();
builder.Services.AddScoped<SeatService, SeatService>();

builder.Services.AddDbContext<OfficeDbContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("sqlconnection"));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

/*builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();*/

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
   
    app.UseSwaggerUI(options =>
           options.SwaggerEndpoint("/swagger/v1/swagger.json", "Office_Seat_Booking_API"));
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseAuthentication();



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();
