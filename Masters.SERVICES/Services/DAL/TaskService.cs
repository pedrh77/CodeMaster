using Masters.DOMAIN.Interfaces;
using Masters.SERVICES.Services.BLL;

namespace Masters.SERVICES.Services.DAL
{
    public class TaskService : ITaskService
    {
        private IClientApiService _clientService;

        public TaskService(IClientApiService clientService)
        {
            _clientService = clientService;
        }

        public async Task TaskGetOperationCalculate()
        {
            var OperationData = await _clientService.ADPGetcalculation();
            if (!OperationData.IsSuccessStatusCode || OperationData.Content == null) { } // Make the Exception 
        }
    }
}
