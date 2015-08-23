using Digirati.IIIF.Model.JsonLD;

namespace Digirati.IIIF.Model.Types.ImageApi
{
    public interface IImageService : IService
    {
        dynamic Profile { get; set; }
    }
}
