namespace backend.Interface.GenericsInterface
{
    public interface GenericInterface<TEntity>
    {
        Task<bool> add(TEntity entity);
        Task<bool> remove(string Id);

        Task<bool> edit(int Id, TEntity entity);

        List<TEntity> getListItems();

        Task SaveChanges();
    }
}
