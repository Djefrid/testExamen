using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture
{
    public class Entreprise
    {
        private List<Facture> factures;
        private String[] nomEntreprise = { "DICJ", "ABC", "CGU", "MSP", "XYZ" };
        private String[] nomProduit = { "PROD01", "PROD17", "PROD_1", "000000", "EXTERN" };
        private String[] descriptionProduit = { "Caisse de fruits", "Processeurs ULTRON", "Muffins (unité)", "MOTEUR", "INCONNU" };
        private String[] nomFournisseur = { "EXPORT X", "F1", "Amozun", "Quebex", "INTERNE" };
        private static Random random = new Random();

        public Entreprise() 
        {
            GenererFacture(20);
        }

        public List<Facture> GetFactures() 
        {
            return factures;
        }

        public int CalculerTotalFacture()
        {
            int totalFacture = 0;
            foreach (Facture item in factures) 
                totalFacture = item.CalculerMontant();

            return totalFacture;
        }

        private void GenererFacture(int nbreFacture)
        {
            factures = new List<Facture>();
            for (int x = 0; x < nbreFacture; x++)
                factures.Add(GenererFactureAleatoire());
        }

        private Facture GenererFactureAleatoire()
        {
            Facture facture = null;
            switch (random.Next(1, 3))
            {
                case 1:
                    facture = new Facture(GetDateTimeAleatoire(), nomEntreprise[random.Next(0, nomEntreprise.Length)]);
                    break;
                case 2:
                    facture = new FactureFourniseur( GetDateTimeAleatoire(), nomEntreprise[random.Next(0, nomEntreprise.Length)], nomFournisseur[random.Next(0, nomFournisseur.Length)]);
                    break;
                case 3:
                    facture = new FactureFourniseurAvecEntente(nomEntreprise[random.Next(0, nomEntreprise.Length)], GetDateTimeAleatoire(), nomFournisseur[random.Next(0, nomFournisseur.Length)]);
                    break;
            }

            for (int x = 0; x < random.Next(0, 10); x++)
            {
                int idProduit = random.Next(0, nomProduit.Length);
                facture.AjouterProduit(new Produit(nomProduit[idProduit], descriptionProduit[idProduit], random.Next(0, 10)));
            }
            return facture;
        }

        private DateTime GetDateTimeAleatoire()
        {
            return new DateTime(2023,random.Next(1,12), random.Next(1, 29));
        }

        public override string ToString()
        {
            string infos = $"ENTREPRISE  \n - Nombre de factures {factures.Count} \n - Total {CalculerTotalFacture()} \n";

            return infos;
        }

    }
}
