using BulkyWeb_Razor.Data;
using BulkyWeb_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWeb_Razor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public List<Category> CategoryList { get; set; }
        public IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }

        public void Post()
        {

        }
    }
}