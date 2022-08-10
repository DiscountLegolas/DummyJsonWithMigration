using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestSharp;
using Newtonsoft.Json;
using WebApplication1.EfCore;
using System.Data.Entity;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private DummyDbcontext _dbcontext;
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public string SelectedCategory { get; set; }
        public List<EfCore.Models.Product>? products { get; set; }
        public List<SelectListItem> Categories;
        public IndexModel(ILogger<IndexModel> logger,DummyDbcontext dbcontext)
        {
            _dbcontext=dbcontext;
            Categories=SelectList.CreateCategoryListFromDatabaseCategoryList(_dbcontext.Categories.ToList());
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            products=_dbcontext.Products.Include(x => x.images).Where(a => a.category == SelectedCategory).ToList();
        }
    }
}