using Masters.DOMAIN.Request;
using Masters.DOMAIN.Response;
using Refit;

namespace Masters.SERVICES.Services.BLL
{
    public interface IClientApiService
    {
        [Get("/api/v1/get-task")]
        Task<ApiResponse<GetCalculationResponse>> ADPGetcalculation();


        [Post("/api/v1/submit-task")]
        Task<ApiResponse<GetCalculationResponse>> ADPPostCalculation(PostCalculationRequest postCalculationRequest);
    }

}

