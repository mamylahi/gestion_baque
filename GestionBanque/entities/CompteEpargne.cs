using System;
namespace GestionBanque.entities
{
	public class CompteEpargne : Compte
	{
		private int duree;
		public CompteEpargne()
		{
		}
        public CompteEpargne(int duree, double solde, Client client) : base(solde, client)
        {
			this.duree = duree;

        }
        public int Duree
        {
            get { return this.duree; }
            set { this.duree = value; }
        }
    }
}

