using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2_5B6.Models
{
    public class Utilisateur
    {
        public Utilisateur(int noUtilisateur, string nomUtilisateur, int typeUtilisateur)
        {
            NoUtilisateur = noUtilisateur;
            NomUtilisateur = nomUtilisateur;
            this.typeUtilisateur = typeUtilisateur;
        }

        public int NoUtilisateur { get; set; }
        public string NomUtilisateur { get; set; }
        public bool EstAdmin => typeUtilisateur == 0;
        private int typeUtilisateur;
    }
}
