using System;

namespace ConsoleAppArme
{
    internal class Program
    {
       
      

        static void Main(string[] args)
        {
            decimal prixBase;
            decimal taxe = 0;

            const decimal taxeForgeeCapitale = 0.20m;
            const decimal taxeAteliersNains = 0.10m;
            const decimal taxeAteliersElfes = 0.05m;
            const decimal taxeMarcheHumains = 0.15m;

            Console.Write("Entrez le prix de base de l'arme en pièces d'or : ");
            prixBase = decimal.Parse(Console.ReadLine());

            // Affichage des options de provenance
            Console.WriteLine("Choisissez la zone de provenance :");
            Console.WriteLine("1 - Forges de la Capitale (20%)");
            Console.WriteLine("2 - Ateliers des Nains des Montagnes (10%)");
            Console.WriteLine("3 - Ateliers des Elfes de la Forêt (5%)");
            Console.WriteLine("4 - Marché des Humains (15%)");

            if (int.TryParse(Console.ReadLine(), out int choixZone))
            {
                switch (choixZone)
                {
                    case 1:
                        taxe = prixBase * taxeForgeeCapitale;
                        break;

                    case 2:
                        taxe = prixBase * taxeAteliersNains;
                        break;

                    case 3:
                        taxe = prixBase * taxeAteliersElfes;
                        break;

                    case 4:
                        taxe = prixBase * taxeMarcheHumains;
                        break;
                }

                decimal prixTotal = prixBase + taxe;

                Console.WriteLine($"Montant de la taxe : {taxe} pièces d'or");
                Console.WriteLine($"Prix total de l'arme : {prixTotal} pièces d'or");
            }
        }
    }
}