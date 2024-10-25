using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
      
        
        Console.WriteLine("Hello, World!");

        Cartecredit carteA = new Cartecredit(numerocarte: 111, description: "credit1", montant:1000);
        Cartecredit carteB = new Cartecredit(numerocarte: 222, description: "credit2", montant: 2000);
        Cartecredit carteC = new Cartecredit(numerocarte: 333, description: "credit3", montant: 3000);

        carteA.AfficherDetails();
        carteB.AfficherDetails();
        carteC.AfficherDetails();

        Console.WriteLine("........");

        PayPal compteA = new PayPal(courriel: "Bricetsaf@gmail.com", description: "compte epargne", montant: 40000);

        PayPal compteB = new PayPal(courriel: "Romaintsaf@gmail.com", description: "compte cheque", montant: 4800);

        compteA.AfficherDetails();
        compteB.AfficherDetails();


        Utilissateur Brice = new Utilissateur("Brice");

        Brice.AjouterPaiement(carteA);

        Brice.AjouterPaiement(carteB);
        Brice.AfficherInfos();



    }
}



