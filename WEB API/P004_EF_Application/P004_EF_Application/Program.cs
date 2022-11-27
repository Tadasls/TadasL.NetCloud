using Microsoft.EntityFrameworkCore;
using P004_EF_Application.Data;
using System.Reflection;
using System.Text.Json.Serialization;

namespace P004_EF_Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<RestaurantContext>(option =>
            {
                option.UseSqlite(builder.Configuration.GetConnectionString("DefaultSQLConection"));
            });

            builder.Services.AddControllers()
                .AddJsonOptions(options=> options.JsonSerializerOptions.ReferenceHandler=ReferenceHandler.IgnoreCycles);


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(option =>
            {
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                option.IncludeXmlComments(xmlPath);
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



//nugets, 
//Context
//reg kaip servisa
//conection stringa
//add migration
//update database
//prie kontrolelio injectinant

