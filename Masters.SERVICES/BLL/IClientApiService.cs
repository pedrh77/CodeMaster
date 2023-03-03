using Masters.DOMAIN.Response;
using Refit;

namespace Masters.SERVICES.BLL
{
    public interface IClientApiService
    {
        [Get("/api/v1/get-task")]
        Task<GetCalculationResponse> ADPGetcalculation();
    }

}
