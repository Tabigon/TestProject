using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestProject.BL.DTO;
using TestProject.BL.Interfaces;

namespace TestProject.Web.Controllers
{
    public class RecordApiController : ApiController
    {
        private readonly IRecordService _recordService;

        public RecordApiController(IRecordService recordService)
        {
            _recordService = recordService;
        }

        public HttpResponseMessage PostRecord(RecordDTO record)
        {
            try
            {
                _recordService.AddRecord(record);

                return Request.CreateResponse(HttpStatusCode.OK);

            }
            catch
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }
    }
}
