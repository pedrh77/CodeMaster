using Masters.DOMAIN.Interfaces;
using Refit;

namespace Masters.SERVICES.Services.DAL
{
    public class ApiResultsService : IApiResultsService
    {
        public void CheckResponseApi<T>(string function, ApiResponse<T> retorno)
        {
            if (!retorno.IsSuccessStatusCode)
            {
                throw new Exception($"[{function}]: Erro: {retorno.Error} Status Code: {retorno.StatusCode} Message: {retorno.Error.Content}");
            }
        }
    }
}