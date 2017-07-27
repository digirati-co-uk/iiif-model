namespace Digirati.IIIF3
{
    public static class UriExtensions
    {
        public static string WithIdentifier(this string s, string identifier)
        {
            return s.Replace("{identifier}", identifier);
        }

        public static string WithName(this string s, string name)
        {
            return s.Replace("{name}", name);
        }

        public static string WithFormat(this string s, string format)
        {
            return s.Replace("{format}", format);
        }
    }
}
