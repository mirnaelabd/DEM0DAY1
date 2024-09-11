using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DEM0DAY1.NewFolder
{
    public class MoviesController : Controller
    {
        public IActionResult GetMovie(int id , string name, employee employee)
        {
            return Content($"Movie with id : {id}");

        }

        //action paramter Binding 
        //1.form 
        //2.segment 
        //3.query string 
        //4.file



        /*    public string Index()
            {
                return " hello from index "; 
            }*/

        public IActionResult Index()
        {
      /*      ContentResult result = new ContentResult();
            result.Content = "hello from Index";*/

            return Content("hello from Index" , "text/html" );
        }

  /*      public RedirectResult test()
        {
            RedirectResult result = new RedirectResult("https://localhost:44301/Movies/Index");
            return result;
        }*/

        public IActionResult test()
        {
            /*  RedirectResult result = new RedirectResult("https://localhost:44301/Movies/Index");
              return result;*/
            // return Redirect("https://localhost:44301/Movies/Index");
            // return RedirectToAction(nameof(Index));
            return RedirectToRoute(new { Controller = "Movies", action = "Index" });
        }


    }
}
