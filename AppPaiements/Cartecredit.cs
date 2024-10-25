using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Cartecredit : Paiement
    {

        public int NumeroCarte { get; set; }

        public Cartecredit(double montant, string description, int numerocarte) : base(montant, description)

        {

            NumeroCarte = numerocarte;

        }


        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"le numero de la carte est {NumeroCarte}");


        }

    
}
}
