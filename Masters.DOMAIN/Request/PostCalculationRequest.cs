using Masters.DOMAIN.Response;
using Refit;

namespace Masters.DOMAIN.Request
{
    public class PostCalculationRequest
    {
        [AliasAs("id")] public Guid id { get; set; }
        [AliasAs("operation")] public string operation { get; set; }
        [AliasAs("left")] public double left { get; set; }
        [AliasAs("right")] public double right { get; set; }
        [AliasAs("result")] public double? result { get; private set; }


        public PostCalculationRequest(GetCalculationResponse response, double value)
        {
            id = response.id;
            operation = response.operation;
            left = response.left;
            right = response.right;
            result = value;

        }

    }
}
