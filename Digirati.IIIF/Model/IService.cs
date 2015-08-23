using Digirati.IIIF.Model.JsonLD;

namespace Digirati.IIIF.Model
{
    public interface IService : IJSONLDBase
    {
        dynamic Service { get; set; } // a service can have service
    }
}
