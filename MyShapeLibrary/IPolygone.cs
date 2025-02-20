using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    interface IPolygone
    {
        // Propriété en lecture seule qui retourne le nombre de sommets
        int NbSommets { get; }
    }
}
