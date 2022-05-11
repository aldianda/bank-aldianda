using System;
namespace Bank_Aldi.Repositories
{
	public interface IRepository<Entity, Key> where Entity : class
	{
		IEnumerable<Entity> Get();
		Entity Get(Key key);
		int Insert(Entity entity);
		int Update(Key key, Entity entity);
		int Delete(Key key);
	}
}

