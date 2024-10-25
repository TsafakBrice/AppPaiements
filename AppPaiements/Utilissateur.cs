using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilissateur
    {
        public string Nom { get; set; }
        public List<Paiement> paiements { get; set; }

        public Utilissateur(string nom)
        {

            Nom = nom;
            paiements = new List<Paiement>();


        }

        public void AfficherInfos()

        {
            Console.WriteLine($"nom d'ulilisateur est {Nom}");
            Console.WriteLine($"Liste de paiement :");
            foreach (Paiement p in paiements)
            {
                Console.Write("....");
                p.AfficherDetails();


            }

        }
        public void AjouterPaiement(Paiement paiement)
        {
            paiements.Add(paiement);


        }




    }
}
