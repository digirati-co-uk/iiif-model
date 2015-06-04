using Digirati.IIIF.Model.Types;
using Digirati.IIIF.Model.Types.ImageApi;
using Newtonsoft.Json;

namespace Digirati.IIIF.Model.Extension
{
    public class DownloadAsService : Service
    {
        [JsonProperty(Order = 10, PropertyName = "format")]
        public string Format { get; set; }

        // add more formats later
        public const string PDFFormat = "http://www.iana.org/assignments/media-types/application/pdf";
        //public const string PDFFormat = "application/pdf";

        public static DownloadAsService GetPdfService(string downloadUri, MetaDataValue label)
        {
            return GetService(downloadUri, label, PDFFormat);
        }

        public static DownloadAsService GetService(string downloadUri, MetaDataValue label, string format)
        {
            return new DownloadAsService
            {
                Context = "http://iiif.io/api/otherManifestations/context.json",
                Id = downloadUri,
                Profile = new UriProfile { Profile = "http://iiif.io/api/otherManifestations.json" },
                Format = format,
                Label = label
            };
        }
    }
}
