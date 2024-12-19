using System;
namespace GestionBanque.entities
{
	public class Agence
	{
		private List<Client> listClient;
		private int id;
		private string code;
		private string libelle;
		private static int cpt = 0;
		
		public Agence()
		{
			id = cpt++;

		}
		public int Id { get { return this.id; }}

		public string Code
		{
			get { return this.code; }
			set { this.code = value; }
		}
        public string Libelle
        {
            get { return this.libelle; }
            set { this.libelle = value; }
        }
        public List <Client> ListClient
        {
            get { return this.listClient; }
            set { this.listClient = value; }
        }
        public string generatelibelle()
		{
			return Id + Code.Substring(0, 3);
		}
        public Agence( string code)
        {
            id = cpt++;
            this.code = code;
			this.libelle = generatelibelle();
			this.listClient = new List<Client>(); 
			
        }
    }
}

