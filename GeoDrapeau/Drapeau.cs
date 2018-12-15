using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoDrapeau
{
    class Drapeau:IComparable
    {
        private string nom;
        private int niveau;
        private string imagePath;

        public string Nom { get => nom; set => nom = value; }
        public int Niveau { get => niveau; set => niveau = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }

        public Drapeau(string nom,int niveau,string imagepath)
        {
            Nom = nom;
            Niveau = niveau;
            ImagePath = imagepath;
        }
        public void chargerFrance()
        {
            Nom = "France";
            Niveau = 1;
            ImagePath = "Assets/flag/France.png";
        }

        public int CompareTo(object obj)
        {
            Drapeau otherJoueur = obj as Drapeau;
            if (this.Niveau > otherJoueur.Niveau) return -1;
            if (this.Niveau == otherJoueur.Niveau) return 0;
            return 1;
        }
    }

}
