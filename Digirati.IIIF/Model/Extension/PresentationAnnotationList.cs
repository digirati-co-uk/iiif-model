using Digirati.IIIF.Model.Types;

namespace Digirati.IIIF.Model.Extension
{
    public class PresentationAnnotationList : AnnotationList
    {
        public override dynamic Context
        {
            get { return "http://iiif.io/api/presentation/2/context.json"; }
        }
    }
}
