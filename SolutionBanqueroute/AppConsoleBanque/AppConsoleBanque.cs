using libBanque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppConsoleBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            //création comptes bancaires
            Console.WriteLine("Création des Comptes");
            CompteBancaire cbPatrick = new CompteBancaire("0211651076B", "M. JANE Patrick");
            CompteBancaire cbTeresa = new CompteBancaire("123121231D", "Mll LISBON Teresa", 1500.00m);
            //Consultation des comptes 
            Console.WriteLine();
            Console.WriteLine("Consultation du compte" + cbPatrick.NumCompte + " de " + cbPatrick.NomTitulaire + " : ");
            Console.WriteLine(" -> Solde : " + cbPatrick.SoldeCompte);
            Console.WriteLine("Consultation du compte" + cbTeresa.NumCompte + " de " + cbTeresa.NomTitulaire + " : ");
            Console.WriteLine(" -> Solde : " + cbTeresa.SoldeCompte);
            //Teresa débite 500€ à patrick
            Console.WriteLine("\n Débiter le compte de Mll Lisbon de 500 Euros : ");
            if (cbTeresa.CrediterCompte(500.0m))
                Console.WriteLine(" -> Opération Impossible pour insuffisance de solde ! ");

            Console.ReadKey();
            Console.ReadLine();

        }
    }
}
