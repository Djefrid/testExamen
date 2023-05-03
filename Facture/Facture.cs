using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture
{
    public class Facture
    {
        private DateTime dateFacturation;
        private string entreprise;
        private List<Produit> produits;

        public Facture(DateTime dateFacturation, string entreprise)
        {
            this.dateFacturation = dateFacturation;
            this.entreprise = entreprise;
            this.produits = new List<Produit>();
        }

        public DateTime DateFacturation
        { get { return dateFacturation; } }

        public string Entreprise
        { get { return entreprise; } }

        public List<Produit> Produits
        { get { return produits; } }

        public void AjouterProduit(Produit produit)
        {
            produits.Add(produit);
        }

        public int CalculerMontant()
        {
            int total = 0;
            foreach (Produit item in produits)
                total += item.Montant;

            return total;
        }

        public override string ToString()
        {
            string infos = $"({dateFacturation})  - {entreprise}\n";

            for (int i = 0; i < produits.Count; i++)
            {
                infos += $"   {produits[i]}\n";
            }
            infos += $"   ­­> {produits.Count} produit/Total : {CalculerMontant()}$\n";

            return infos;
        }


    }
}
