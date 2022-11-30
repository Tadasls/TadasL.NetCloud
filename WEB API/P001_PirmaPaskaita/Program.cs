using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text.Json.Serialization;

namespace L05_Tasks_MSSQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddTransient<IBookWrapper, BookWrapper>();

            builder.Services.AddDbContext<KnygynasContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("MyDefaultSQLConnection"));
                //cia kiti nustatymai jei reiktu SQL Lite  -  option.UseSqlite(builder.Configuration.GetConnectionString("MyDefaultSQLConnection"));
            });

            builder.Services.AddControllers()
                .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(
                options =>
                {
                    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                    options.IncludeXmlComments(xmlPath);
                });

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

            app.UseCors("corsforTLS");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}