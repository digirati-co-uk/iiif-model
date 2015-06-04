using Digirati.IIIF.Model.Types;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Extension
{
    public class SearchResultAnnotationList : AnnotationList
    {
        public override string Context
        {
            get { return "http://iiif.io/api/presentation/2/context.json"; }
        }

        [JsonProperty(Order = 10, PropertyName = "within")]
        public SearchResultsLayer Within { get; set; }
    }
}
