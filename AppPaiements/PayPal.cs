using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class PayPal : Paiement
    {

        public string Courriel { get; set; }

        public PayPal(double montant, string description, string courriel) : base(montant, description)

        {
            Courriel = courriel;
        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"le Courriel est {Courriel}");
        }
    }
}
