using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digirati.IIIF.Model.Types;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model
{
    public class AcceptTermsService : Service
    {
        public override dynamic Profile
        {
            get { return "http://wellcomelibrary.org/ld/iiif-ext/0/accept-terms-click-through"; }
        }
        
        // do we need an extra setting to tell a viewer whether it can "pull through" (import into interface)?
        [JsonProperty(Order = 102, PropertyName = "wdl:fullTerms")]
        public string WdlFullTerms { get; set; }

        [JsonProperty(Order = 102, PropertyName = "wdl:fullTermsHtml")]
        public string WdlFullTermsHtml { get; set; }

        [JsonProperty(Order = 103, PropertyName = "wdl:actionLabel")]
        public MetaDataValue WdlActionLabel { get; set; }

    }
}
