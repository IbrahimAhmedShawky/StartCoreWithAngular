using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]

    
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context=context;
        }
        [HttpGet]
            public async Task<IActionResult> GetValues(){
            var values=await  _context.Value.ToListAsync();
            return Ok(values);
            
        }
       
    
    }
}