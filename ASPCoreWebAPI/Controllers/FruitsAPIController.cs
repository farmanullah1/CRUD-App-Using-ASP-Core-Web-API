using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsAPIController : ControllerBase
    {
        public List<string> fruits = new List<string>()
        {
            "Apple",
            "Banana",
            "Mango",
            "Orange",
            "Pineapple",
            "Grapes"
        };
        [HttpGet]
        public List<string> GetFruits()
        {
            return fruits;
        }
        [HttpGet("{id}")]
        public string GetFruits(int id)
        {
            return fruits.ElementAt(id);
        }
    }
}
