using Digirati.IIIF.Model;
using Digirati.IIIF.Model.Types;
using Digirati.IxIF;
using Newtonsoft.Json;

namespace Digirati.IIIF.UVExtensions
{
    public class AcceptTermsService : GenericService
    {
        //public override dynamic Context
        //{
        //    get { return ExtensionUriPatterns.WdlExtensionsContext; }
        //}
        //public override dynamic Profile
        //{
        //    get { return "http://wellcomelibrary.org/ld/iiif-ext/0/accept-terms-click-through"; }
        //}
        
        // previously fullTerms
        [JsonProperty(Order = 102, PropertyName = "license")]
        public string License { get; set; }

        //[JsonProperty(Order = 102, PropertyName = "fullTermsSimple")]
        //public string FullTermsSimple { get; set; }

        //[JsonProperty(Order = 103, PropertyName = "actionLabel")]
        //public MetaDataValue ActionLabel { get; set; }

        //[JsonProperty(Order = 103, PropertyName = "autoClosingVersionOfId")]
        //public string AutoClosingVersionOfId { get; set; }

    }
}
