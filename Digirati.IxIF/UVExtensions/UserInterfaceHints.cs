using Digirati.IIIF.Model.Types;
using Digirati.IxIF;
using Newtonsoft.Json;

namespace Digirati.IIIF.UVExtensions
{
    public class UserInterfaceHints : GenericService
    {
        public override dynamic Context
        {
            get { return ExtensionUriPatterns.WdlExtensionsContext; }
        }
        public override dynamic Profile
        {
            get { return "http://universalviewer.azurewebsites.net/ui-extensions-profile"; }
        }


        // do we need an extra setting to tell a viewer whether it can "pull through" (import into interface)?
        [JsonProperty(Order = 102, PropertyName = "manifestType")]
        public string ManifestType { get; set; }

        [JsonProperty(Order = 104, PropertyName = "suppressMetadata")]
        public string[] SuppressMetadata { get; set; }

        
    }
}
