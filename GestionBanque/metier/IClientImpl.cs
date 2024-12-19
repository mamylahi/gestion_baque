using System;
using GestionBanque.entities;
using GestionBanque.interfaces;

namespace GestionBanque.metier
{
	public class IClientImpl : IRepository <Client>
	{
		private Agence ag;
        ICompteImpl compte;

        public IClientImpl(Agence ag)
        {
            this.ag = ag;
        }

        public  Agence Ag
        {
            get { return this.ag; }
            set { this.ag = value; }
        }

        public void add()
        {
            Console.WriteLine("Donner le nom");
            string nom = Console.ReadLine();
            Console.WriteLine("Donner le prenom");
            string prenom = Console.ReadLine();
            Console.WriteLine("Donner le tel");
            string tel = Console.ReadLine();

            Client client = new Client(nom, prenom, tel, compte);

            if (ag.ListClient.Exists(a => a.Tel.Equals(client.Tel)))
            {
                Console.WriteLine("Ce numero existe deja");
            }
            else
            {
                ag.ListClient.Add(client);
                Console.WriteLine("client ajouté avec success");
            }

        }

        public void afficheDetails()
        {
            foreach (Client client in ag.ListClient) {
                Console.WriteLine("id" +client.Id + "nom" +client.Nom + "prenom" +client.Prenom + "tel" +client.Tel);
        }
        }
        public void delete(Client t)
        {
            if (ag.ListClient.Exists(a => a.Tel == t.Tel))
            {
                ag.ListClient.Remove(t);
            }
            else
            {
                Console.WriteLine("ce client n'existe pas");
            }
        }

        public void update(Client t)
        {
            
                Client clientupdate = ag.ListClient.Find(u => u.Tel.Equals( t.Tel));
            if (clientupdate != null) { 
                Console.WriteLine("donner le nom de mis à jour");
                clientupdate.Nom = Console.ReadLine();
                Console.WriteLine("donner le prenom de mis à jour");
                clientupdate.Prenom = Console.ReadLine();
                Console.WriteLine("donner le tel de mis à jour");
                clientupdate.Tel = Console.ReadLine();

                Console.WriteLine("client modifier avec success");
            }else
            {
                Console.WriteLine("Ce client exist deja");
            }

        }
    
    }
}

