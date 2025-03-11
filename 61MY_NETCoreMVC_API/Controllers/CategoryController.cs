using _61MY_NETCoreMVC_API.DAL.APIContext;
using _61MY_NETCoreMVC_API.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace _61MY_NETCoreMVC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategoryList()
        {
            using var context = new Context();
            return Ok(context.Categories.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            using var context = new Context();
            var value = context.Categories.Find(id);

            if(value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }

        [HttpPost]
        public IActionResult AddCateogry(Category p)
        {
            using var context = new Context();
            context.Add(p);
            context.SaveChanges();
            return Created("", p);
        }

        [HttpDelete]
        public IActionResult DeleteCateogry(int id)
        {
            using var context = new Context();
            var value = context.Categories.Find(id);

            if (value == null)
            {
                return NotFound();
            }
            else
            {
                context.Remove(value);
                context.SaveChanges();
                return NoContent();
            }
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category p)
        {
            using var context = new Context();
            var value = context.Find<Category>(p.CategoryId);

            if(value == null)
            {
                return NotFound();
            }
            else
            {
                value.CategoryName = p.CategoryName;
                context.Update(value);
                context.SaveChanges();
                return NoContent();
            }
        }
    }
}
