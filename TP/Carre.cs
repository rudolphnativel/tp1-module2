using System;

namespace TP
{
    internal class Carre : Forme
    {
        public Carre()
        {
        }
        public Carre(int Longueur)
        {
            this.Longueur = Longueur;
        }
        public int Longueur { get; set; }

        public override string ToString()
        {
            int aire = Longueur * Longueur;
            int perimetre = Longueur * 4;

            string reponse = $"Carré de côté {Longueur}\nAire = {aire}\nPérimètre = {perimetre}";
           
            return reponse + "\n" ;
        }
    }
}