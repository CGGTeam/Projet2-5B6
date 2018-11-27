using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2_5B6.Models
{
    public class Utilisateur
    {
        public Utilisateur(int no, string nom, string prenom, int noType)
        {
            this.no = no;
            this.nom = nom;
            this.prenom = prenom;
            this.noType = noType;
        }

        public Utilisateur(Employe employe)
        {
            this.no = employe.No;
            this.nom = employe.Nom;
            this.prenom = employe.Prenom;
            this.noType = employe.NoTypeEmploye;
        }

        public int no { get; }
        public string nom { get; }
        public string prenom { get; }
        public int noType { get; }

    }
}
