using CRMobil.Entities.Cliente;
using CRMobil.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using CRMobil.Entities.ServicosOficina;
using CRMobil.Interfaces;

namespace CRMobil.Services
{
    public class ServicosOficinaServices : IServicosOficinaServices
    {
        private readonly IMongoCollection<ServicosOficina> _serviceCollection;

        public ServicosOficinaServices(IOptions<CnnStoreDatabaseSettings> serviceCollection)
        {
            var mongoCollection = new MongoClient(serviceCollection.Value.ConnectionString);

            var mongoDatabase = mongoCollection.GetDatabase(serviceCollection.Value.DatabaseName);

            _serviceCollection = mongoDatabase.GetCollection<ServicosOficina>("Servicos");
        }

        public async Task<List<ServicosOficina>> GetAsync() => await _serviceCollection.Find(_ => true).ToListAsync();

        public async Task<ServicosOficina?> GetAsync(string id) => await _serviceCollection.Find(x => x.Id_Servico == id).FirstOrDefaultAsync();

        public async Task<ServicosOficina?> GetDescricaoAsync(string descricao) => await _serviceCollection.Find(x => x.Descricao == descricao).FirstOrDefaultAsync();

        public async Task CreateAsync(ServicosOficina createModel) => await _serviceCollection.InsertOneAsync(createModel);

        public async Task UpdateAsync(string id, ServicosOficina updateModel) => await _serviceCollection.ReplaceOneAsync(x => x.Id_Servico == id, updateModel);

        public async Task RemoveAsync(string id) => await _serviceCollection.DeleteOneAsync(x => x.Id_Servico == id);

    }
}
