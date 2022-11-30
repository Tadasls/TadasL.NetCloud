using Microsoft.EntityFrameworkCore;
using P02_Rest_Endpoints.Data;
using System.Reflection;
using System.Text.Json.Serialization;

namespace P02_Rest_Endpoints
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<DataContex>(option =>
            {
                option.UseSqlite(builder.Configuration.GetConnectionString("TLSMySQLConection"));
            });

            builder.Services.AddControllers()
                .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


          
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddCors(p => p.AddPolicy("corsforfood", builder =>
            {
                builder.WithOrigins("*")
                .AllowAnyMethod().AllowAnyHeader();  

            }));

            builder.Services.AddCors(p => p.AddPolicy("corsforTLS", builder =>
            {
                builder.WithOrigins("*")
                .AllowAnyMethod().AllowAnyHeader();

            }));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("corsforfood");  
            app.UseCors("corsforTLS");  

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}