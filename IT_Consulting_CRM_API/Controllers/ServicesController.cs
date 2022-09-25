using IT_Consulting_CRM_API.Data;
using IT_Consulting_CRM_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT_Consulting_CRM_API.Controllers
{
    /// <summary>
    /// Контроллер услуг
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        public static DataContext Context { get; set; }
        public ServicesController(DataContext dataContext)
        {
            Context = dataContext;
        }
        [HttpPost]
        public async Task Post([FromBody] Services service)
        {
            await Context.Service.AddAsync(service);
            await Context.SaveChangesAsync();
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Services getservice)
        {
            Services service = Context.Service.ToList().Find(u => u.Id == getservice.Id);
            Context.Service.Update(service);
            await Context.SaveChangesAsync();
            return Ok();
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<Services>> Get()
        {
            return await Context.Service.ToListAsync();
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Services service = Context.Service.ToList().Find(u => u.Id == id);
            Context.Service.Remove(service);
            await Context.SaveChangesAsync();
            return Ok();
        }
    }
}