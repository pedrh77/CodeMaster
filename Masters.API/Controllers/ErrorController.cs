using Masters.DOMAIN.ViewModel;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Masters.API.Controllers
{
    [ApiController, Route("[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        [HttpGet]
        public ErrorResponseVm HandleError() {
            IExceptionHandlerFeature contexto = HttpContext.Features.Get<IExceptionHandlerFeature>();
            Exception excecao = contexto?.Error!;

            HttpStatusCode httpStatusCode = excecao switch
            {
                KeyNotFoundException _ => HttpStatusCode.NotFound,
                ArgumentException _ => HttpStatusCode.ServiceUnavailable,
                MissingFieldException _ => HttpStatusCode.BadRequest,
                _ => HttpStatusCode.NotFound
            };
            Response.StatusCode = (int)httpStatusCode;
            return new ErrorResponseVm(Response.StatusCode.ToString(), excecao.Message, excecao.Data?.Cast<object>().FirstOrDefault());
        }
    }
}
