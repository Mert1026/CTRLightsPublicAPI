using CTRLightsPublicAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace CTRLightsPublicAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Ensure appsettings.json is loaded
            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Register DbContext with PostgreSQL (use correct connection string)
            var connectionString = builder.Configuration.GetConnectionString("SupabaseDb");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

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
