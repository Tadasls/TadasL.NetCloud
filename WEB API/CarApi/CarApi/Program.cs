
using CarApi.Database;
using CarApi.Models;
using CarApi.Repositories;
using CarApi.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CarApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<CarContext>(options =>
            {
                options.UseSqlite(builder.Configuration.GetConnectionString("MyDefaultSQLConnection"));
            });

            builder.Services.AddTransient<ICarRepository, CarRepository>();
            builder.Services.AddTransient<ICarAdapter, CarAdapter>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(
           options =>
           {
               var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
               var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
               options.IncludeXmlComments(xmlPath);
           });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}