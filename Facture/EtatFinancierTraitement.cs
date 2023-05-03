using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture
{
    public partial class EtatFinancier
    {
        private List<Facture> factures;

        public EtatFinancier()
        {
            factures = new List<Facture>();
        }

        public void AjouterFacture(Facture facture)
        {
            factures.Add(facture);
        }

        public  int CalculerTotalFacture()
        {
            int totalFacture = 0;
            foreach (Facture item in factures) 
                totalFacture += item.CalculerMontant();

            return totalFacture;
        }
    }
}
