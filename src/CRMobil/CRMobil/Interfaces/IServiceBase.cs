using MongoDB.Driver;

namespace CRMobil.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAsync();

        Task<TEntity?> GetAsync(string id);

        Task CreateAsync(TEntity createModel);

        Task UpdateAsync(string id, TEntity updateModel);

        Task RemoveAsync(string id);

        void Dispose();
    }
}
