using Newtonsoft.Json;

namespace Masters.DOMAIN.Response
{
    public class GetCalculationResponse
    {
        [JsonProperty("id")] public Guid id { get; set; }
        [JsonProperty("operation")] public string? operation { get; set; }
        [JsonProperty("left")] public double left { get; set; }
        [JsonProperty("right")] public double right { get; set; }
    }
}
