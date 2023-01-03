
using Microsoft.EntityFrameworkCore;
using PresentC2invoice.Service;
using PresentC2invoice.Service.IService;
using PressentConnection.Data;

namespace PresentC2invoice
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

            builder.Services.AddScoped<IInvoiceService, InvoiceService >();

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