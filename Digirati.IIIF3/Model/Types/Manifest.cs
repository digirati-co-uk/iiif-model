using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Digirati.IIIF3.Model.Types
{
    public class Manifest : PresentationBase
    {
        public string ViewingDirection { get; set; }
        
        public List<Sequence> Sequences { get; set; }
        
        public List<Range> Structures { get; set; }
    }
}
