using ApiMokymai.Data;
using ApiMokymai.Interfaces;
using ApiMokymai.Services;

namespace ApiMokymai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });


            builder.Services.AddControllers();
            // Add services to the container.
            builder.Services.AddSingleton<IBookSet, BookSet>();
            builder.Services.AddTransient<IBookWraper, BookWrapper>();
            builder.Services.AddTransient<IBookManager, BookManager>();


            //builder.Services.AddTransient<IMyOperationTransient, GuidService>();
            //builder.Services.AddScoped<IMyOperationScoped, GuidService>();
            //builder.Services.AddSingleton<IMyOperationSingleton, GuidService>();



           
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
            app.UseCors("_allowAny");

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.UseCors();

            app.Run();
        }
    }
}