
using System.Web.Http;
using Axolotl.Services;

namespace Axolotl.Controllers
{
    [Route("api/data")]
    public class DataController : ApiController
    {
        private readonly IDataService _dataService;

        public DataController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var entry = _dataService.GetLatest();
            return Ok(entry);
        }
    }
}