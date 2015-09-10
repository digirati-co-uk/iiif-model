using Digirati.IIIF.Model.JsonLD;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digirati.IIIF.Model.Types.Search
{
    public class TermList : JSONLDBase, IHasIgnorableParameters
    {
        public override dynamic Context
        {
            get { return "http://iiif.io/api/search/0/context.json"; }
        }

        public override string Type
        {
            get { return "search:TermList"; }
        }

        [JsonProperty(Order = 20, PropertyName = "ignored")]
        public string[] Ignored { get; set; }

        [JsonProperty(Order = 40, PropertyName = "terms")]
        public Term[] Terms { get; set; }
    }
}
