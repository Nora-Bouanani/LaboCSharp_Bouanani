using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{

    public class Coordonnee
    {
        // Variables membres privées
        private int x;
        private int y;

        // Propriétés publiques
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        // Constructeur par défaut
        public Coordonnee() : this(0, 0)
        {
        }

        // Constructeur d'initialisation
        public Coordonnee(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Surcharge de ToString()
        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
