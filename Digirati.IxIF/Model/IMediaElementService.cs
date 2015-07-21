using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digirati.IIIF.Model.JsonLD;

namespace Digirati.IIIF.Model
{
    public interface IMediaElementService : IJSONLDBase
    {
        dynamic Profile { get; set; }
    }
}
