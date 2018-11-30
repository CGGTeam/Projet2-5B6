using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2_5B6.Models
{
    class TypeAbonnementPrix
    {
        public int No { get; set; }
        public string Description { get; set; }
        public DateTime Annee { get; set; }
        public decimal Prix { get; set; }
        public decimal Depense { get; set; }
        public string Remarque { get; set; }

        public TypeAbonnementPrix(int no, string description, DateTime date, decimal prix, decimal depense, string remarque)
        {
            this.No = no;
            this.Description = description;
            this.Annee = date;
            this.Prix = prix;
            this.Depense = depense;
            this.Remarque = remarque;
        }

        public TypeAbonnementPrix()
        {
        }

    }
}
