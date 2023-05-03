using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture
{
    internal class Comptabilite
    {
        private EtatFinancier etat;

        public Comptabilite()
        {
            etat = new EtatFinancier();
        }

        public void TraiterFacture(Facture facture)
        {
            if (facture.Produits.Count == 0)
                throw new ComptabiliteException("Aucun produit", facture) ;

            if (facture is FactureFourniseur)
                if (((FactureFourniseur)facture).Entente == true)
                    foreach (Produit item in facture.Produits)
                        if (item.Montant == 0)
                            throw new ComptabiliteException("Produit à 0", facture);

            etat.AjouterFacture(facture);
        }

        public int ValideretatFinancier(Entreprise entreprise)
        {
            return etat.CalculerTotalFacture() - entreprise.CalculerTotalFacture(); 
        }

        public bool ValiderEtatFinancier(Entreprise entreprise, int tolerance)
        {
            return Math.Abs(ValideretatFinancier(entreprise)) < tolerance;
        }

        public EtatFinancier Etat
        { get { return etat; } }
    }
}
