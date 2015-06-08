namespace Digirati.IIIF.Model.Types.Auth
{
    public class Token
    {
        public string AccessToken { get; set;}
        public const string TokenType = "Bearer";
        public int ExpiresIn { get; set;}
    }
}
