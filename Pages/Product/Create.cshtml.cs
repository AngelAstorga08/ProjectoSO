using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectoSO.Models;
using System.Threading.Tasks;

namespace ProjectoSO.Pages.Product
{
    public class CreateModel : PageModel
    {
        private readonly ProductContext _context;

        public CreateModel(ProductContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Producto Product { get; set; }
        
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Add(Product);
            await _context.SaveChangesAsync();

            TempData["Message"] = "Producto agregado";

            return RedirectToPage("./Create"); // Redirige a la misma página para mostrar el mensaje
        }
    }
}