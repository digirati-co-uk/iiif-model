using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digirati.IIIF.Model.Types.Search
{
    public interface IHasIgnorableParameters
    {
        string[] Ignored { get; set; }
    }
}
