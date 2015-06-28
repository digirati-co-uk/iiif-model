using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digirati.IIIF.Serialisation
{
    public static class ExtensionMethods
    {
        // returns an object or an array of objects, depending on how many in the IEnumerable.
        public static object ToDynamicValue<T>(this IEnumerable<T> values)
        {
            if (values == null) return null;
            var list = values.ToList();
            if (!list.Any())
            {
                return null;
            }
            if (list.Count == 1)
            {
                return list[0];
            }
            return list.ToArray();
        }
    }
}
