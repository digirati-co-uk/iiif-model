namespace Digirati.IIIF.Model.Types.Auth
{
    /// <summary>
    /// The JSON object submitted to the optional Client identity Service
    /// </summary>
    public class ClientCredentials
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set;}
    }
}
