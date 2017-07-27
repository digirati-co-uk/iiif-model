using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using Digirati.IIIF3.Model.Types;

namespace Digirati.IIIF3.Model.Types
{
    public class Canvas : PresentationBase
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public float Duration { get; set; }
        public List<AnnotationPage> Content { get; set; } 
    }
}
