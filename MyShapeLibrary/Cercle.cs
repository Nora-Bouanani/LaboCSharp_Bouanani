using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    public class Cercle : Forme, IEstDans
    {
        // Variable membre privée
        private int rayon;

        // Propriété publique pour accéder à la rayon
        public int Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        // Propriété calculée pour le diamètre (lecture seule)
        public int Diametre
        {
            get { return rayon * 2; }
        }

        // Constructeur par défaut (position (0,0) et rayon = 1)
        public Cercle() : base()
        {
            rayon = 1;
        }

        // Constructeur d'initialisation (avec un point et une rayon)
        public Cercle(Coordonnee point, int rayon) : base(point)
        {
            this.rayon = rayon;
        }

        // Surcharge de ToString() pour afficher un carré
        public override string ToString()
        {
            return $"Cercle [Rayon = {rayon}, Diamètre = {Diametre}, Point d'accroche = {PointAccroche}]";
        }

        public bool CoordonneeEstDans(Coordonnee p)
        {
            //explication dans:www.mathnirvana.com/fr/math-rules/equation-of-a-circle.htm

            double distance = Math.Sqrt(Math.Pow(p.X - PointAccroche.X, 2) + Math.Pow(p.Y - PointAccroche.Y, 2));
            return distance <= rayon; // Vérifie si distance ≤ Rayon

        }

    }
}
