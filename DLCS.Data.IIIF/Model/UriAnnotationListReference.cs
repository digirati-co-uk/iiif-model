using Digirati.IIIF.Serialisation;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    [JsonConverter(typeof(ToStringJsonConverter))]
    public class UriAnnotationListReference : IAnnotationListReference
    {
        public string AnnotationListUri { get; set; }

        public override string ToString()
        {
            return AnnotationListUri;
        }
    }
}
