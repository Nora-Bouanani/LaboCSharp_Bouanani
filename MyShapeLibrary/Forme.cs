using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyShapeLibrary
{
    // Déclaration de la classe abstraite
    public abstract class Forme
    {
        // Variable membre privée
        private Coordonnee pointAccroche;

        // Propriété publique
        public Coordonnee PointAccroche
        {
            get { return pointAccroche; }
            set { pointAccroche = value; }
        }

        // Constructeur par défaut (initialise à (0,0))
        public Forme()
        {
            pointAccroche = new Coordonnee(0, 0);
        }

        // Constructeur d'initialisation
        public Forme(Coordonnee point)
        {
            pointAccroche = point;
        }
    }
}
