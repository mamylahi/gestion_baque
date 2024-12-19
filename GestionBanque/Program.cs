using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBanque.entities;
using GestionBanque.metier;

namespace Gestion_Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c, choice;
            Console.WriteLine("===MENU===");
            Console.WriteLine("1- Agence");
            Console.WriteLine("2- Client");
            Console.WriteLine("3- Compte");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    do
                    {
                        IAgenceImpl agence = new IAgenceImpl();
                        Agence ag = null;
                        Console.WriteLine("===MENU AGENCE===");
                        Console.WriteLine("1- Ajouter une Agence");
                        Console.WriteLine("2- Modifier une Agence");
                        Console.WriteLine("3- Supprimer une Agence");
                        Console.WriteLine("4- Quitter");
                        c = int.Parse(Console.ReadLine());
                        switch (c)
                        {
                            case 1:
                                agence.add();
                                break;
                            case 2:
                                Console.WriteLine("Donner le code de l'agence");
                                string code = Console.ReadLine();
                                ag = new Agence(code);
                                agence.update(ag);
                                break;
                            case 3:
                                Console.WriteLine("Donner le code de l'agence");
                                code = Console.ReadLine();
                                ag = new Agence(code);
                                agence.delete(ag);
                                break;
                            case 4:
                                Console.WriteLine("Merci de quitter CRUD Agence");
                                break;
                            default:
                                Console.WriteLine("Choix inexistant");
                                break;
                        }
                    } while (c != 4);
                    break;
                case 2:
                    do
                    {
                        Console.WriteLine("Donner le code de l'agence");
                        string code = Console.ReadLine();
                        Agence agence = new Agence(code);
                        Client cl = null;
                        IClientImpl client = new IClientImpl(agence);
                        Console.WriteLine("===MENU Client===");
                        Console.WriteLine("1- Ajouter un client");
                        Console.WriteLine("2- Modifier un client");
                        Console.WriteLine("3- Supprimer un client");
                        Console.WriteLine("4- Quitter");
                        c = int.Parse(Console.ReadLine());
                        if (c == 2 || c== 3) { 
                        client.afficheDetails();
                        Console.WriteLine("Donner l'id du client");
                        int id = int.Parse(Console.ReadLine());
                         cl = agence.ListClient.Find(c => c.Id == id);
                        }
                        switch (c)
                        {
                            case 1:
                                client.add();
                                break;
                            case 2:
                               
                                client.update(cl);
                                break;
                            case 3:
                                client.delete(cl);
                                break;
                            case 4:
                                Console.WriteLine("Merci de quitter CRUD Agence");
                                break;
                            default:
                                Console.WriteLine("Choix inexistant");
                                break;
                        }
                    } while (c != 4);
                    break;


            }
        }
    }
}