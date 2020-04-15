using System;

namespace TP
{
    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override string ToString()
        { 
            double perimetre = A + B + C;
            double p = perimetre / 2;
            
            double pA = p-A;
            double pB = p-B;
            double pC = p-C;

            double result =p* pA*pB*pC;
            //double result =p * (p - C) * (p - A) * (p - B); 
            double aire = Math.Sqrt(result);
            string reponse = $"Triangle de côté A = {A} B = {B} C = {C}\nAire = {aire}\nPérimètre = {perimetre}";
            return reponse;
        }
    }
}