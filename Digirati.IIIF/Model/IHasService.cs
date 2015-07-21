
namespace Digirati.IIIF.Model
{
    public interface IHasService
    {
        string Id { get; set; }
        dynamic Service { get; set; }
        dynamic Profile { get; set; }
    }
}
