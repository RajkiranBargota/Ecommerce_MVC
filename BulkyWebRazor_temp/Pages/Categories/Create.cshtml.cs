using BulkyWeb_Razor.Data;
using BulkyWeb_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_temp.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");

        }
    }
}
