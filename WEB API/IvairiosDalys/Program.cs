using ApiMokymai.Controllers.P001;
using ApiMokymai.Data;
using ApiMokymai.Interfaces;
using ApiMokymai.Interfaces.Kiti;
using ApiMokymai.Services;
using ApiMokymai.Services.KitiServisai;
using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace L05_Tasks_MSSQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //builder.Services.AddSingleton<IBookSet, BookSet>();
            //builder.Services.AddTransient<IBookManager, BookManager>();

            builder.Services.AddTransient<IMyOperationTransient, GuidService>();
            builder.Services.AddScoped<IMyOperationScoped, GuidService>();
            builder.Services.AddSingleton<IMyOperationSingleton, GuidService>();


            builder.Services.AddTransient<IBadService, BadService>();
            builder.Services.AddTransient<INegalimaDalyba, Skaiciuokle>();


            builder.Services.AddTransient<IBookWrapper, BookWrapper>();
            builder.Services.AddDbContext<BookStoreContext>(option =>
            {
             option.UseSqlite(builder.Configuration.GetConnectionString("MyDefaultSQLConnection"));
            });

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