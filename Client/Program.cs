using IRemote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            BankInterface bn = (BankInterface)Activator.GetObject(typeof(BankInterface), "tcp://localhost:2048/bank");

            operations();
            while (flag)
            {
                int id;
                int op;
                string name;

                Console.Write('>');
                int.TryParse(Console.ReadLine(), out op);
                

                switch (op)
                {
                    case 1:
                        Console.WriteLine("entrer l'id de nouveau compte: ");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine("entrer le nom de nouveau compte: ");
                        name = Console.ReadLine();
                        Console.WriteLine("entrer le solde inicial de nouveau compte: ");
                        double solde = double.Parse(Console.ReadLine());


                        if (bn.creeCompte(id, name, solde))
                        {
                            Console.WriteLine("compte creé avec succes");
                        }
                        else
                        {
                            Console.WriteLine("échec");
                        }
                        break;

                    case 2:
                        Console.WriteLine("entrer l'id de compte à débiter: ");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine("entrer le montant à débiter: ");
                        solde = double.Parse(Console.ReadLine());


                        Console.WriteLine(bn.debiter(id, solde));
                        break;

                    case 3:
                        Console.WriteLine("entrer l'id de compte à créditer: ");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine("entrer le montant à créditer: ");
                        solde = double.Parse(Console.ReadLine());


                        Console.WriteLine(bn.crediter(id, solde));
                        break;

                    case 4:
                        Console.WriteLine("entrer l'id de compte: ");
                        Console.WriteLine(bn.consulter(int.Parse(Console.ReadLine())));

                        break;

                    case 5:
                        operations();
                        break;

                    case 6:
                        flag = false;
                        Console.WriteLine("exit.");
                        break;

                    default:
                        break;
                }
            }
        }

        static void operations()
        {
            Console.WriteLine("opérations:");
            Console.WriteLine("1. créer compte.");
            Console.WriteLine("2. débiter compte.");
            Console.WriteLine("3. créditer compte.");
            Console.WriteLine("4. consulter solde.");
            Console.WriteLine("5. liste des opérations.");
            Console.WriteLine("6. sortir.");
        }
    }
}
