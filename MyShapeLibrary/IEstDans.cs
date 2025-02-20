using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    public interface IEstDans
    {
        // Méthode pour vérifier si un point est dans une forme
        bool CoordonneeEstDans(Coordonnee p);
    }
}

