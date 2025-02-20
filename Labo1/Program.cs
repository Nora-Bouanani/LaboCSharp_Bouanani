using System;
using MyShapeLibrary;

namespace Labo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------TEST DE COORDONNEE------------------------

            Console.WriteLine("=========  TEST DE COORDONNEE ========= ");
            Coordonnee p1 = new Coordonnee();  
            Coordonnee p2 = new Coordonnee(5, 10); 

            Console.WriteLine($"(constructeur par defaut) Coordonnée: {p1}");
            Console.WriteLine($"(constructeur d'initialisation) Coordonnée: {p2}");



            //------------------------TEST DE CARRE------------------------

            Console.WriteLine("\n========= TEST DE CARRE =========");
            Carre c1 = new Carre();  
            Carre c2 = new Carre(p2, 4); 

            Console.WriteLine($"(constructeur par defaut) Carre : {c1}");
            Console.WriteLine($"(constructeur d'initialisation) Carre : {c2}");



            //------------------------TEST DE CERCLE------------------------

            Console.WriteLine("\n=========  TEST DE CERCLE ========= ");
            Cercle cercle1 = new Cercle();
            Cercle cercle2 = new Cercle(p2, 5);

            Console.WriteLine($"(constructeur par defaut) Cercle : {cercle1}");
            Console.WriteLine($"(constructeur d'initialisation) Cercle : {cercle2}");



            //------------------------TEST DE RECTANGLE------------------------

            Console.WriteLine("\n=========  TEST DE RECTANGLE ========= ");
            Rectangle rectangle1 = new Rectangle();
            Rectangle rectangle2 = new Rectangle(p2, 8, 4);

            Console.WriteLine($"(constructeur par defaut) Rectangle : {rectangle1}");
            Console.WriteLine($"(constructeur d'initialisation) Rectangle : {rectangle2}");
            


            //------------------------TEST DES VALEURS------------------------

            Console.WriteLine("\n=========  MODIFICATION TEST ========= ");
            Console.WriteLine($"Avant modification : {c2.PointAccroche}");
            c2.PointAccroche.X = 20;
            Console.WriteLine("Modification: x=20");
            Console.WriteLine($"Après modification : {c2.PointAccroche}");

            Console.WriteLine("\n=========  TEST DE REFERENCE ========= ");
            Console.WriteLine($"Sont-ils egaux ? {p2} et {c2.PointAccroche}");
            Console.WriteLine(object.ReferenceEquals(p2, c2.PointAccroche) ? "=>Les objets sont identiques " : "=>Les objets sont différents");



            //------------------------TEST DE IEstDans------------------------

            Console.WriteLine("\n=========(carre) TEST DE IEstDans =========");
            Coordonnee p3 = new Coordonnee(21, 10);
            Console.WriteLine($"Le point {p3} est-il dans Carre ? {c2.CoordonneeEstDans(p3)}");

            Coordonnee p4 = new Coordonnee(7, 14);
            Console.WriteLine($"Le point {p4} est-il dans Carre ? {c2.CoordonneeEstDans(p4)}");


            Console.WriteLine("\n=========(rectangle) TEST DE IEstDans =========");

            Coordonnee p6 = new Coordonnee(21, 10);
            Console.WriteLine($"Le point {p6} est-il dans Rectangle  ? {rectangle2.CoordonneeEstDans(p6)}");

            Coordonnee p7 = new Coordonnee(28, 9);
            Console.WriteLine($"Le point {p7} est-il dans Rectangle  ? {rectangle2.CoordonneeEstDans(p7)}");


            Console.WriteLine("\n=========(cercle) TEST DE IEstDans =========");

            Coordonnee p8 = new Coordonnee(21, 10);
            Console.WriteLine($"Le point {p8} est-il dans Cercle  ? {cercle2.CoordonneeEstDans(p8)}");

            Coordonnee p9 = new Coordonnee(20, 20);
            Console.WriteLine($"Le point {p9} est-il dans Cercle  ? {cercle2.CoordonneeEstDans(p9)}");

        }
    }
}
