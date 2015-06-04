using Digirati.IIIF.Model.Types;

namespace Digirati.IIIF.Model.Extension
{
    public class SearchResultAnnotation : Annotation
    {
        public override string Motivation
        {
            get { return "sc:painting"; }
        }
    }
}
