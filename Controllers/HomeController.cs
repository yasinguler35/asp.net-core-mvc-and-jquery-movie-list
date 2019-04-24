using Microsoft.AspNetCore.Mvc;
using mvc_movie.Data;
using mvc_movie.Models;

namespace mvc_movie.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        public IActionResult Index(){
            return View(MovieRepository.Moives);
        }
        [HttpGet]
        public IActionResult Contact(){
            return View();
        }
        public IActionResult Details(int id)
        {
            // TODO: Your code here
            return View(MovieRepository.GetById(id));
        }
        
    }
}