using System;
using GestionBanque.metier;
namespace GestionBanque.entities
{
    public class Client
    {
        private int id;
        private string prenom;
        private string nom;
        private string tel;
        private static int cpt = 0;
        private Compte compte;

        public Client()
        {
            id = cpt++;
        }
        public int Id { get { return this.id; } }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public string Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }
        public Compte Compte
        {
            get { return this.compte; }
            set { this.compte = value; }
        }

        public  Client (string prenom, string nom, string tel,ICompteImpl compte)
        {
            id = cpt++;
            this.prenom = prenom;
            this.nom = nom;
             this.tel = tel;
            this.compte = compte.Cl.Compte;
        }
    }
}


