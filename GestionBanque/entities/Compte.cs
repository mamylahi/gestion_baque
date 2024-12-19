using System;
namespace GestionBanque.entities
{
	public class Compte
	{
        private int id;
        private double solde;
		private string numcompte;
		private Client client;
		private static int cpt;

        public Compte()
		{
			id = cpt++;
		}
        public int Id { get { return this.id; } }

        public double Solde
        {
            get { return this.solde; }
            set { this.solde = value; }
        }
        public string NumCompte
        {
            get { return this.numcompte; }
            set { this.numcompte = value; }
        }
        
        public Client Client
        {
            get { return this.client; }
            set { this.client = value; }
        }
        public string generateNumCompte()
        {
            return "000" +Id + client.Tel ;
        }

        public Compte (double solde, Client client)
        {
            id = cpt++;
            this.solde = solde;
            this.numcompte = generateNumCompte();
            this.client = client;
        }
    }
}


