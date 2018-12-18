using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoDrapeau
{
    class Joueur:IComparable
    {
        private string nom,prenom;
        private int score;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Score { get => score; set => score = value; }

        public Joueur(string nom,string prenom,int score)
        {
            Nom = nom;
            Prenom = prenom;
            Score = score;
        }

        public override string ToString()
        {
            return "Nom : " + Nom + " Prénom : " + Prenom + " Score : " + Score;
        }

        public int CompareTo(object obj)
        {
            Joueur otherJoueur = obj as Joueur;
            if (this.Score > otherJoueur.Score) return -1;
            if (this.Score == otherJoueur.Score) return 0;
            return 1;
        }

        public string joueurString
        {
            get { return Nom + " | " + Prenom + " |  Score : " + Score; }

        }
    }
}
