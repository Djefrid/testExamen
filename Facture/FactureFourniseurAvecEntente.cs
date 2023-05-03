using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture
{
    internal class FactureFourniseurAvecEntente : FactureFourniseur
    {
        public FactureFourniseurAvecEntente(string entreprise, DateTime dateFacturation, string fournisseur) : base(dateFacturation,entreprise, fournisseur, true)
        {
        }

    }
}
