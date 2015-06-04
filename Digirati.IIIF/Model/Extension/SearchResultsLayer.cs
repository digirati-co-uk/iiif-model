using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Extension
{
    /// <summary>
    /// Each AnnotationList references a Layer.  The Layer can be a blank node, and must be included in every annotation list. 
    /// </summary>
    public class SearchResultsLayer : JSONLDBase
    {
        public override string Type
        {
            get { return "sc:Layer"; }
        }

        [JsonProperty(Order = 10, PropertyName = "total")]
        public int Total { get; set; }


        [JsonProperty(Order = 20, PropertyName = "pageSize")]
        public int PageSize { get; set; }
    }
}
