using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2_5B6.ObjetsLINQ
{
   class ObjetDepensesParAnneeEtAbonnement
   {
      public int annee { get; set; }
      public string idAbonne { get; set; }
      public string nomCompletAbonne { get; set; }
      public decimal montant { get; set; }
      public DateTime dateDepense { get; set; }
      public string typeService { get; set; }
      public string nomCompletEmploye { get; set; }
   }
}
