using Microsoft.AspNetCore.Mvc;
using mvc_movie.Data;

namespace mvc_movie.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(){
            return View(CategoryRepository.Categories);
        }
    }
}