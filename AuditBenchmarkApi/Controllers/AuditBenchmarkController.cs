using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuditBenchmarkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditBenchmarkController : ControllerBase
    {
        private static Dictionary<string, int> bench = new Dictionary<string, int>
        {
            {"Internal", 3 },
            {"SOX", 1 }
        };
        [HttpGet]
        public async Task<ActionResult<IDictionary<string, int>>> Get()
        {
            return Ok(bench);
        }
    }
}
