namespace WebApplication1.models.Repositories
{
    public interface IEmployeeRepository<TEntity>
    {
        IList<TEntity> list();
        TEntity Find(int id);
        void Add(Entity entity);
        void update(Entity entity , DateTime date);
        void delete(int id);
    }
}
