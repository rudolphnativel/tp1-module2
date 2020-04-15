namespace TP
{
    internal class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public override string ToString()
        {
            int aire = Longueur * Largeur;
            int perimetre = (Longueur + Largeur)*2;
            string reponse = $"Rectangle de longueur = {Longueur} et de largeur = {Largeur}\nAire = {aire}\nPérimètre = {perimetre}";
            return reponse+"\n";
        }
    }
}