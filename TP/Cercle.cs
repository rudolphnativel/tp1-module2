using System;

namespace TP
{
    internal class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override string ToString()
        {
            double aire = Rayon* Rayon * Math.PI;
            double perimetre = Rayon * 2 * Math.PI;
            string reponse = $"Cercle de rayon {Rayon}\nAire = {aire}\nPérimètre = {perimetre}";
            return reponse+"\n";
        }
    }
}