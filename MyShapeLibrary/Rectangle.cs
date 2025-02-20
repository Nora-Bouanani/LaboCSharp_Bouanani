using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    public class Rectangle : Forme, IEstDans, IPolygone
    {

        // Variables membres privées
        private int longueur;
        private int largeur;

        // Propriétés publiques pour accéder à la longueur et à la largeur
        public int Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public int Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

        public int NbSommets => 4; // Un rectangle a toujours 4 sommets


        public Rectangle() : base()
        {
            longueur = 1; // Longueur par défaut
            largeur = 1;  // Largeur par défaut
        }

        // Constructeur d'initialisation
        public Rectangle(Coordonnee point, int longueur, int largeur) : base(point)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        // Surcharge de la méthode ToString()
        public override string ToString()
        {
            return $"Rectangle [Longueur = {longueur}, Largeur = {largeur}, Point d'accroche = {PointAccroche}]";
        }

        // Implémentation de IEstDans
        public bool CoordonneeEstDans(Coordonnee p)
        {
            int xMin = PointAccroche.X;                // Coin supérieur gauche (X)
            int yMin = PointAccroche.Y;                // Coin supérieur gauche (Y)
            int xMax = xMin + longueur;                 // Coin inférieur droit (X)
            int yMax = yMin + largeur;                 // Coin inférieur droit (Y)

            return (p.X >= xMin && p.X <= xMax) && (p.Y >= yMin && p.Y <= yMax);
        }
    }
}
