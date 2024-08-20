using Microsoft.EntityFrameworkCore;
using ProjectoSO.Models; // Asegúrate de que este namespace sea correcto

namespace ProjectoSO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Añadir servicios al contenedor.
            builder.Services.AddRazorPages();

            // Configurar el contexto de la base de datos
            builder.Services.AddDbContext<ProductContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // Configurar la tubería de solicitudes HTTP.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}