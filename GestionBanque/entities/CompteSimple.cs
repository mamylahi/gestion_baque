using System;
namespace GestionBanque.entities
{
	public class CompteSimple : Compte
	{
		private double tauxdecouvert;
		public CompteSimple()
		{
		}
		public CompteSimple(double tauxdecouvert, double solde, Client client) : base(solde, client)
        {
			this.tauxdecouvert = tauxdecouvert;
        }
        public double Tauxdecouvert
        {
            get { return this.tauxdecouvert; }
            set { this.tauxdecouvert = value; }
        }
    }
}

