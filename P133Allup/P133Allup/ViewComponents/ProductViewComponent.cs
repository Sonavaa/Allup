using Microsoft.AspNetCore.Mvc;
using P133Allup.DataAccessLayer;

namespace P133Allup.ViewComponents
{
    public class ProductViewComponent :ViewComponent
       
    {
        private readonly AppDbContext _context;
        public ProductViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
