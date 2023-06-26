using CRMobil.Entities;
using CRMobil.Entities.Oficina;
using CRMobil.Entities.ServicosOficina;
using CRMobil.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CRMobil.Services
{
    public class OficinasServices : IOficinasServices
    {
        private readonly IMongoCollection<Oficinas> _serviceCollection;

        public OficinasServices(IOptions<CnnStoreDatabaseSettings> serviceCollection)
        {

            var mongoCollection = new MongoClient(serviceCollection.Value.ConnectionString);

            var mongoDatabase = mongoCollection.GetDatabase(serviceCollection.Value.DatabaseName);

            _serviceCollection = mongoDatabase.GetCollection<Oficinas>("Oficinas");
        }

        public async Task<Oficinas> GetAsync() => await _serviceCollection.Find(_ => true).FirstOrDefaultAsync();

        public async Task<Oficinas?> GetAsync(string id) => await _serviceCollection.Find(x => x.Id_Oficina == id).FirstOrDefaultAsync();

        public async Task<Oficinas?> GetCnpjAsync(string id) => await _serviceCollection.Find(x => x.Id_Oficina == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Oficinas createModel) => await _serviceCollection.InsertOneAsync(createModel);

        public async Task UpdateAsync(Oficinas updateModel) => await _serviceCollection.ReplaceOneAsync(x => x.Id_Oficina == updateModel.Id_Oficina, updateModel);

        public async Task RemoveAsync(string id) => await _serviceCollection.DeleteOneAsync(x => x.Id_Oficina == id);
    }
}
