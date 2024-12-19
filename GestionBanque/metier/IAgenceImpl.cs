using System;
using GestionBanque.interfaces;
using GestionBanque.entities;
namespace GestionBanque.metier;

	public class IAgenceImpl : IRepository <Agence>
	{
    static List<Agence> listAgence = new List<Agence>();
	

    public void add()
    {
        Console.WriteLine("saisir code:");
        string c = Console.ReadLine();
        Agence a = new Agence(c);
        listAgence.Add(a);
        afficheDetails();
    }

    public void afficheDetails()
    {
        foreach (Agence agence in listAgence) { 
        Console.WriteLine("id :" +agence.Id + " code " +agence.Code + " libelle" +agence.Libelle);
            
    }
    }

    public void delete(Agence t)
    {
        if (listAgence.Exists(d => d.Code == t.Code )) {
            listAgence.Remove(t);
        }else
        {
            Console.WriteLine("cette agence n'existe pas");

        }
        afficheDetails();
    }

    public void update(Agence t)

    {
        
        if (listAgence.Exists(u => u == t))
        {
            Agence agenceupdate = listAgence.Find(u => u == t);
            Console.WriteLine("donner le code de mis à jour");
             string code= Console.ReadLine();
            if (listAgence.Exists(u => u.Code.Equals(code)))
            {
                Console.WriteLine("Erreur ce code existe deja");
            }
        }
        else
        {
            Console.WriteLine("cette agence n'existe pas");
        }

        afficheDetails();
    }
}

