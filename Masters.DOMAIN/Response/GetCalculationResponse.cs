using Newtonsoft.Json;

namespace Masters.DOMAIN.Response
{
    public class GetCalculationResponse
    {
        [JsonProperty("id")] public string id { get; set; }
        [JsonProperty("operation")] public string operation { get; set; }
        [JsonProperty("left")] public long left { get; set; }
        [JsonProperty("right")] public long right { get; set; }
    }
}
