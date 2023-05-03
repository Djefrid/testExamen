using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture
{
    partial class EtatFinancier
    {
        public override string ToString()
        {
            string infos = $"ETAT FINANCIER \n  - Nombre de factures {factures.Count} \n  - Total {CalculerTotalFacture()} \n";

            return infos;
        }
    }
}
