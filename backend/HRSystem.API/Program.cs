using HRSystem.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using HRSystem.Application.Interfaces;
using HRSystem.Application.Services;
using HRSystem.Domain.Repositories;
using HRSystem.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register IEmployeeService with its implementation
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

// Register IEmployeeRepository with its implementation
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//add Core services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});


builder.Services.AddControllers();

// Register other services, such as application services and repositories
// builder.Services.AddTransient<IEmployeeService, EmployeeService>();
// builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.UseCors("AllowAllOrigins");


app.Run();
