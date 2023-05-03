using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture
{
    internal class FactureFourniseur : Facture
    {
        private string fourniseur;
        private bool entente;

        public FactureFourniseur(DateTime dateFacturation,string entreprise, string fourniseur, bool entente = false) : base(dateFacturation,entreprise)
        {
            this.fourniseur = fourniseur;
            this.entente = entente;
        }

        public string Fourniseur
        { get { return fourniseur; } }

        public bool Entente
        { get { return entente; } }
    }
}
