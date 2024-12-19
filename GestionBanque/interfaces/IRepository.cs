using System;
namespace GestionBanque.interfaces
{
	public interface IRepository <T>
	{
		public void add();
		public void update(T t);
		public void delete(T t);
		public void afficheDetails();
	}
}

