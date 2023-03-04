using Masters.DOMAIN.Interfaces;
using Masters.DOMAIN.Request;
using Masters.DOMAIN.Response;
using Masters.SERVICES.Services.BLL;

namespace Masters.SERVICES.Services.DAL
{
    public class TaskService : ITaskService
    {
        private IClientApiService _clientService;
        private IApiResultsService _apiResults;

        public TaskService(IClientApiService clientService, IApiResultsService apiResults)
        {
            _clientService = clientService;
            _apiResults = apiResults;
        }

        public async Task TaskGetOperationCalculate()
        {
            var requestGetOperation = await APIGetOperationAsync();
            var value = CheckExecuteOperation(requestGetOperation);
            await APIExecuteOperationAsync(requestGetOperation, value);
        }

        public async Task<GetCalculationResponse> TaskGetOperation()
        {
            return await APIGetOperationAsync();
        }

        private async Task<GetCalculationResponse> APIGetOperationAsync()
        {
            var OperationData = await _clientService.ADPGetcalculation();
            _apiResults.CheckResponseApi("ADPGetcalculation", OperationData);
            return OperationData.Content;
        }

        private async Task APIExecuteOperationAsync(GetCalculationResponse getCalculationResponse, double value)
        {
            var request = new PostCalculationRequest(getCalculationResponse, value);
            var CalculationResult = await _clientService.ADPPostCalculation(request);
            _apiResults.CheckResponseApi("ADPPostCalculation", CalculationResult);

        }

        private double CheckExecuteOperation(GetCalculationResponse requestGetOperation)
        {
            Console.WriteLine($"[CheckExecuteOperation]: The Operation Is {requestGetOperation.operation}"); //Logger
            if (requestGetOperation.operation == "remainder") return requestGetOperation.left % requestGetOperation.right;
            if (requestGetOperation.operation == "division") return ((int)requestGetOperation.left / requestGetOperation.right);
            if (requestGetOperation.operation == "addition") return (requestGetOperation.left + requestGetOperation.right);
            if (requestGetOperation.operation == "subtraction") return (requestGetOperation.left - requestGetOperation.right);
            if (requestGetOperation.operation == "multiplication") return (requestGetOperation.left * requestGetOperation.right);
            throw new Exception("[CheckExecuteOperation] Operation Not Found");
        }

    }
}
