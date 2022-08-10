using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using WebApplication1;
using WebApplication1.EfCore.Models;

namespace WebApplication1
{
    public static class SelectList
    {
        public static List<SelectListItem> CreateCategoryListFromJson(string json) {
            List<string> ms= JsonConvert.DeserializeObject<List<string>>(json);
            var result =
                ms.Select(v =>
                    new SelectListItem(
                    v.ToString(),
                    v.ToString()
                    )
                )
                .ToList();
            return result;
        }
        public static List<SelectListItem> CreateCategoryListFromDatabaseCategoryList(List<Category> categories)
        {
            List<string> ms= new List<string>();
            foreach (var item in categories)
            {
                ms.Add(item.CategoryName);
            }
            var result =
                ms.Select(v =>
                    new SelectListItem(
                    v.ToString(),
                    v.ToString()
                    )
                )
                .ToList();
            return result;
        }
    }
}
