using System;
using GestionBanque.entities;
using GestionBanque.interfaces;

namespace GestionBanque.metier
{
	public class ICompteImpl : IRepository <Compte>
	{
        private Client cl;
        private Compte cp;

		public ICompteImpl( Client cl)
		{
            this.cl = cl;
		}
        public Client Cl
        {
            get { return this.cl; }
            set { this.cl = value; }
        }

        public void add()
        {
            Console.WriteLine("donner le solde");
            double solde = double.Parse(Console.ReadLine());
            Console.WriteLine("quel type de compte souhaitez vous ajouté??");
            Console.WriteLine("1-- Compte Simple");
            Console.WriteLine("2-- Compte Epargne");
            int choix = int.Parse(Console.ReadLine());
            if (choix == 1)
            {
                Console.WriteLine("saisir taux de couvert");
                double tauxdecouvert =double.Parse( Console.ReadLine());
                CompteSimple compte = new CompteSimple(solde, tauxdecouvert,Cl) ;

            }
            else if (choix == 2)
            {
                Console.WriteLine("saisir la duree");
                int duree = int.Parse(Console.ReadLine());
                CompteEpargne compte = new CompteEpargne(duree,solde,cl);
            }else
            {
                Console.WriteLine("Choix invalide");
            }
        }

        public void afficheDetails()
        {
            Console.WriteLine(cl.Compte is CompteEpargne? "compte epargne" : "compte simple");
            Console.WriteLine("id" + cp.Id);
            Console.WriteLine("solde" + cp.Solde);
            Console.WriteLine("numero compte" + cp.NumCompte);
            if ( cl.Compte is CompteEpargne epargne)
            {
                Console.WriteLine("duree" + epargne.Duree);
            }else if (cl.Compte is CompteSimple simple)
            {
                Console.WriteLine("tauxde couvert" + simple.Tauxdecouvert);
            }
            else
            {
                Console.WriteLine("compte inexistant");
            }

        }

        public void delete(Compte t)
        {
            if (cl.Compte != null && cl.Compte == t)
            {
                cl.Compte = null;
                Console.WriteLine("compte supprimé avec success");
            }
            else
            {
                Console.WriteLine("ce compte n'existe pas");
            }
        }

        public void update(Compte t)
        {
            if (cl.Compte != null && cl.Compte == t)
            {
                Console.WriteLine("Donner le code");
                string code = Console.ReadLine();

                if (t is CompteEpargne epargne)
                    {
                    Console.WriteLine("saisir la duree");
                        epargne.Duree = int.Parse(Console.ReadLine());

                    }else if (t is CompteSimple simple)
                {
                    Console.WriteLine("saisir le taux de couvert");
                    simple.Tauxdecouvert = double.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("ce type de compte nexiste pas");
                }
            }
            
        }
    }
}

