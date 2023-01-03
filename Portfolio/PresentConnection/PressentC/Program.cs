using Microsoft.EntityFrameworkCore;
using PressentC.Service;
using PressentC.Service.IService;
using PressentConnection.Data;

namespace PressentC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<DataBaseContext>(option =>
            {
                option.UseSqlite(builder.Configuration.GetConnectionString("MyDefaultSQLConnection"));
                // option.UseLazyLoadingProxies();
            });

            builder.Services.AddTransient<IOptimizationService, OptimizationService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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