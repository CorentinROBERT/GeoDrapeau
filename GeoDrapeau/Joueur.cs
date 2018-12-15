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
        private string mail;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Score { get => score; set => score = value; }
        public string Mail { get => mail; set => mail = value; }

        public Joueur(string nom,string prenom,int score,string mail)
        {
            Nom = nom;
            Prenom = prenom;
            Score = score;
            Mail = mail;
        }
        public override string ToString()
        {
            return "Nom : "+Nom+" Prénom : "+Prenom+" Score : "+Score+" Mail : "+Mail;
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
            get { return Nom + " | " + Prenom + " |  Score : " + Score + " | "+Mail; }

        }
    }
}
