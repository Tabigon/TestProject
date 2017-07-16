using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestProject.BL.DTO;
using TestProject.BL.Interfaces;

namespace TestProject.Web.Controllers
{
    // В целях демонстрации своих знаний я реализовал это приложение с использованием трехуровневой архитектуры и внедрением зависимостей
    // но в случае подобной простоты реального приложения, разбивать его на уровни нецелесообразно
    public class RecordApiController : ApiController
    {
        private readonly IRecordService _recordService;

        public RecordApiController(IRecordService recordService)
        {
            _recordService = recordService;
        }

        public HttpResponseMessage PostRecord(RecordDTO record)
        {
            if (!ModelState.IsValid)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);

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
