using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TinaLeonBlog.Controllers
{
    public class BlogController : ControllerBase
    {
        [Route("[controller]")]
        [HttpGet]
        public ActionResult Get()
        {
            MongoCRUD db = new MongoCRUD("Blog");
            var results = db.LoadRecords<PostsModel>("Posts");
            foreach(var rec in results)
            {
                Console.WriteLine(rec.Id + " " + rec.Name);
            }
            Console.ReadLine();
            return(results);
        }
    }
}
