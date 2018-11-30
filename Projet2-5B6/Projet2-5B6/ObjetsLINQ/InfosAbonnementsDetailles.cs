using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2_5B6.ObjetsLINQ
{
   class InfosAbonnementsDetailles
   {
      public int noTypeAbonnement { get; private set; }
      public string descriptionAbonnement { get; private set; }
      public decimal prix { get; private set; }
      public decimal depenseObligatoire { get; private set; }
      public DateTime date { get; private set; }

      public InfosAbonnementsDetailles(int noTypeAbonnement, string descriptionAbonnement, decimal prix, decimal depenseObligatoire, DateTime date)
      {
         this.noTypeAbonnement = noTypeAbonnement;
         this.descriptionAbonnement = descriptionAbonnement;
         this.prix = prix;
         this.depenseObligatoire = depenseObligatoire;
         this.date = date;
      }
   }
}
