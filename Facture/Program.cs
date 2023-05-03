using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entreprise monEntreprise = new Entreprise();

            Console.WriteLine(monEntreprise.ToString());
            Console.WriteLine($"Liste des factures :\n");
            foreach (Facture item in monEntreprise.GetFactures())
                Console.WriteLine(item);

            Comptabilite maComptabilite = new Comptabilite();

            foreach (Facture item in new Entreprise().GetFactures())
                try
                {
                    maComptabilite.TraiterFacture(item);
                }
                catch (ComptabiliteException ex)
                {
                    Console.WriteLine(ex);
                }

            Console.WriteLine(monEntreprise);
            Console.WriteLine(maComptabilite.Etat);
            Console.WriteLine("La balance est de " + maComptabilite.ValideretatFinancier(monEntreprise) + "$");
            Console.WriteLine("Etat financier valide :  " + maComptabilite.ValiderEtatFinancier(monEntreprise, 50));

        }
    }
}
