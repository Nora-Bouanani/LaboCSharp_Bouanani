using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    public class Carre : Forme, IEstDans, IPolygone
    {
        // Variable membre privée
        private int longueur;

        // Propriété publique pour accéder à la longueur
        public int Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public int NbSommets => 4; // Un carré a toujours 4 sommets

        // Constructeur par défaut (position (0,0) et longueur = 1)
        // base permet dappelr le const. def. de forme avant carree
        public Carre() : base()
        {
            longueur = 1;
        }

        // Constructeur d'initialisation (avec un point et une longueur)
        public Carre(Coordonnee point, int longueur) : base(point)
        {
            this.longueur = longueur;
        }

        // Surcharge de ToString() pour afficher un carré
        public override string ToString()
        {
            return $"Carre[PointAccroche={PointAccroche}, Longueur={longueur}]";
        }

        public bool CoordonneeEstDans(Coordonnee p)
        {
            // coin supérieur gauche du carré
            int xMin = PointAccroche.X;
            int yMin = PointAccroche.Y;

            //coin inférieur droit 
            int xMax = xMin + longueur;
            int yMax = yMin + longueur;

            //(voir dessin)
            return (p.X >= xMin && p.X <= xMax) && (p.Y >= yMin && p.Y <= yMax);
        }

    }
}

