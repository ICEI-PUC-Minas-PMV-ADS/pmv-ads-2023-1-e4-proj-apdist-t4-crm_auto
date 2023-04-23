using CRMobil.Entities;
using CRMobil.Entities.ServicosOficina;
using CRMobil.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CRMobil.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IMongoCollection<TEntity> _serviceCollection;

        public ServiceBase(IOptions<CnnStoreDatabaseSettings> serviceCollection)
        {
            
            var mongoCollection = new MongoClient(serviceCollection.Value.ConnectionString);

            var mongoDatabase = mongoCollection.GetDatabase(serviceCollection.Value.DatabaseName);

            _serviceCollection = mongoDatabase.GetCollection<TEntity>(nameof(TEntity));
        }

        public Task CreateAsync(TEntity createModel)
        {
            return _serviceCollection.InsertOneAsync(createModel);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAsync()
        {
            return _serviceCollection.Find(_ => true).ToListAsync();
        }

        public Task<TEntity?> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, TEntity updateModel)
        {
            throw new NotImplementedException();
        }

        //public Task<TEntity?> GetAsync(string id)
        //{
        //    return _serviceCollection.Find(x => x.Id_Servico == id).FirstOrDefaultAsync();
        //}

        //public Task RemoveAsync(string id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task UpdateAsync(string id, TEntity updateModel)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
