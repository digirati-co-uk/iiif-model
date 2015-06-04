using Newtonsoft.Json;

namespace Digirati.IIIF.Model.JsonLD
{
    public class LanguageValue : ValueObject
    {
        //@language
        [JsonProperty(Order = 4, PropertyName = "@language")]
        public string Language { get; set; }

    }
}
