using Refit;

namespace Masters.DOMAIN.Request
{
    public class PostCalculationRequest
    {
        [AliasAs("id")] public int Id { get; set; }
        [AliasAs("result")] public string Result { get; set; }
    }
}
