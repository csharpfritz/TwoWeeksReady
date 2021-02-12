using Newtonsoft.Json;

namespace TwoWeeksReady.EmergencyKits
{
    public class KitItem
    {        
        [JsonProperty(PropertyName = "id")]
        public string Id {get; set;}
       
        [JsonProperty(PropertyName = "userId")]
        public string UserId {get; set;}

        [JsonProperty(PropertyName = "name")]
        public string Name {get; set;}
        
        [JsonProperty(PropertyName = "description")]
        public string Description {get;set;}

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity {get;set;}

        [JsonProperty(PropertyName = "unit")]
        public string QuantityUnit {get;set;}

        [JsonProperty(PropertyName = "photo")]
        public string Photo {get;set;} // URL ?
        
        [JsonProperty(PropertyName = "isAvailableInKit")]
        public bool IsAvailableInKit {get;set;} //checklist for user to see if they have everything they need.
    }
}