using gestionTareas.Models;
using gestionTareas.Repository;
using gestionTareas.Services;
using Microsoft.EntityFrameworkCore;

namespace gestionTareas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            //Conexion a DB
            builder.Services.AddDbContext<TareaContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("MiConexion")));


            builder.Services.AddScoped<ITareaService, TareaService>();
            builder.Services.AddScoped<ITareaRepository, TareaRepository>();

            //permisos de para acceder a la API
            var MyAllowOrigins = "MyAllowOrigins";
            builder.Services.AddCors(opstions =>
            {
                opstions.AddPolicy(name: MyAllowOrigins,
                    p =>
                    {
                        p.AllowAnyHeader();
                        p.AllowAnyOrigin();
                    }
                    );
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseCors(MyAllowOrigins);

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
