using Masters.DOMAIN.Response;

namespace Masters.DOMAIN.Interfaces
{
    public interface ITaskService
    {
        Task<GetCalculationResponse> TaskGetOperation();
        Task TaskGetOperationCalculate();
    }
}
