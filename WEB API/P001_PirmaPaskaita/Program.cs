using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using WebAppMSSQL.Data;
using WebAppMSSQL.Repository;
using WebAppMSSQL.Repository.IRepository;
using WebAppMSSQL.Services;
using WebAppMSSQL.Services.IServices;

namespace L05_Tasks_MSSQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<KnygynasContext>(option =>
            {
                // option.UseSqlServer(builder.Configuration.GetConnectionString("MyDefaultSQLConnection"));
                 option.UseSqlite(builder.Configuration.GetConnectionString("MyDefaultSQLConnection2"));

               // option.UseLazyLoadingProxies();
                //cia kiti nustatymai jei reiktu SQL Lite  -  option.UseSqlite(builder.Configuration.GetConnectionString("MyDefaultSQLConnection"));
            });

            builder.Services.AddTransient<IDebtsService, DebtsService>();
            builder.Services.AddTransient<IStockService, StockService>();
            builder.Services.AddTransient<IUserHelpService, UserHelpService>();

            builder.Services.AddTransient<IBookWrapper, BookWrapper>();
            builder.Services.AddTransient<IReservationWrapper, ReservationWrapper>();

            builder.Services.AddScoped<IUpdateBookRepository, BookUpdateRepository>();

            
            builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IPasswordService, PasswordService>();
            builder.Services.AddScoped<IJwtService, JwtService>();

            var key = builder.Configuration.GetValue<string>("ApiSettings:Secret");

            builder.Services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
             .AddJwtBearer(x =>
             {
                 x.RequireHttpsMetadata = false;
                 x.SaveToken = true;
                 x.TokenValidationParameters = new TokenValidationParameters()
                 {
                     ValidateIssuerSigningKey = true,
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                     ValidateIssuer = false,
                     ValidateAudience = false
                 };
             });


            builder.Services.AddControllers()
                .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(option =>
            {
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                option.IncludeXmlComments(xmlPath);

                // This is added to show JWT UI part in Swagger
                option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Description =
                        "JWT Authorization header is using Bearer scheme. \r\n\r\n" +
                        "Enter 'Bearer' and token separated by a space. \r\n\r\n" +
                        "Example: \"Bearer d5f41g85d1f52a\"",
                    Name = "Authorization", // Header key name
                    In = ParameterLocation.Header,
                    Scheme = "Bearer",
                    BearerFormat = "JWT"
                });

                option.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme()
                        {
                            Reference = new OpenApiReference()
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        },
                        new List<string>()
                    }
                });
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

            app.UseAuthentication(); // Order matters
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}