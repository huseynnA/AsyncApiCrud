using DataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Abstraction;
    
namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostController : ControllerBase
    {
     //   private readonly IHostService _HostService;
       private readonly IQueryService _QueryService;
        HostController(IHostService hostService,IQueryService queryService) 
        {
          //  _HostService = hostService;
            _QueryService = queryService;
        } 

        [HttpGet("GetAsync")]
        public async Task<Query> GetAsync(int id) 
        {
         var query= await _QueryService.GetAsync(id);

            if (query == null)
            {
                throw new Exception("User not found");
            }
            else return query;
            
        }
    }
}
