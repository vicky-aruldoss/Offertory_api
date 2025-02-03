using Newtonsoft.Json;

namespace Offertory_model;

public class OfferingDetails
{
    public int Id { get; set; }
    [JsonProperty("Name")]
    public string MemberName {get; set;}
    public decimal? Amount { get; set; }
}
