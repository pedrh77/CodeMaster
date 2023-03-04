using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masters.DOMAIN.Interfaces
{
    public interface IApiResultsService 
    {
        public void CheckResponseApi<T>(string function, ApiResponse<T> retorno);
    }
}
