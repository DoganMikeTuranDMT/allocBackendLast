using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Allocation.DTO;
using Allocation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Allocation.Controllers
{
    [Route("api/[controller]")]
    public class SkillController : Controller
    {
        private readonly remnz1Context _context;

        public SkillController(remnz1Context context)
        {
            _context = context;

        }

        
        [HttpGet("{clientid}")]
        
        public async Task<ActionResult<IEnumerable<FoSkill>>> Get(int clientid)
        {
            return await _context.FoSkill.Where(x => x.ClientId == clientid).ToListAsync();
        }

     
       [HttpPost]
        public string PostSkill([FromBody]FoSkill foskill)
        {
            _context.FoSkill.Add(foskill);
            _context.SaveChanges();
            return foskill.Id.ToString();
        }
    }
}
