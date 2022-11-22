namespace P02_Rest_Endpoints
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
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