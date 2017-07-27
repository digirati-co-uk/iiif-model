using System.Collections;

namespace Digirati.IIIF3.Serialisation
{
    public static class SerialisationHelpers
    {
        public static bool HasText(this string s)
        {
            // .NET 4:
            return !string.IsNullOrWhiteSpace(s);
        }


        public static bool HasContent(this object o)
        {
            if (o == null) return false;
            var list = o as IList;
            if (list != null && list.GetType().IsGenericType)
            {
                if (list.Count > 0 && list[0] != null) return true;
                return false;
            }
            var s = o as string;
            if (s != null)
            {
                return !string.IsNullOrWhiteSpace(s);
            }
            return true;
        }

    }
}
