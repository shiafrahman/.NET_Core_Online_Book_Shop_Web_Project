using DOTNETCORERazor_Temp.Models;
using DOTNETCORERazor_Temp.NewFolder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DOTNETCORERazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Category> CategoryList { get; set; }    
        public void OnGet()
        {
            CategoryList=_db.Categories.ToList();
        }
    }
}
