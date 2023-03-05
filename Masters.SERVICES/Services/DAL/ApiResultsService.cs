using Masters.DOMAIN.Interfaces;
using Refit;
using System.Net;

namespace Masters.SERVICES.Services.DAL
{
    public class ApiResultsService : IApiResultsService
    {
        public void CheckResponseApi<T>(string function, ApiResponse<T> retorno)
        {
            if (retorno.StatusCode == HttpStatusCode.NotFound) throw new KeyNotFoundException($"[{function}]: {retorno.Error.Content}");

            if (retorno.StatusCode == HttpStatusCode.BadRequest) throw new MissingFieldException($"[{function}]: {retorno.Error.Content}");

            if (retorno.StatusCode == HttpStatusCode.ServiceUnavailable) throw new ArgumentException($"[{function}]: {retorno.Error.Content}");
        }
    }
}