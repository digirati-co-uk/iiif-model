using Digirati.IIIF.Model.JsonLD;

namespace Digirati.IIIF.Model.Types.ImageApi
{
    public interface IImageService : IJSONLDBase
    {
        dynamic Profile { get; set; }
    }
}
