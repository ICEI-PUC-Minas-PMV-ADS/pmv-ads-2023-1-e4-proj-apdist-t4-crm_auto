using CRMobil.Entities.Oficina;
using CRMobil.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using CRMobil.Entities.Veiculos;
using CRMobil.Interfaces;

namespace CRMobil.Services
{
    public class VeiculosServices : IVeiculosServices
    {
        private readonly IMongoCollection<Veiculos> _serviceCollection;

        public VeiculosServices(IOptions<CnnStoreDatabaseSettings> serviceCollection)
        {

            var mongoCollection = new MongoClient(serviceCollection.Value.ConnectionString);

            var mongoDatabase = mongoCollection.GetDatabase(serviceCollection.Value.DatabaseName);

            _serviceCollection = mongoDatabase.GetCollection<Veiculos>("Veiculos");
        }

        public async Task<List<Veiculos>> GetAsync() => await _serviceCollection.Find(_ => true).ToListAsync();

        public async Task<Veiculos?> GetAsync(string id) => await _serviceCollection.Find(x => x.Id_Veiculo == id).FirstOrDefaultAsync();

        public async Task<Veiculos> GetPlacaAsync(string descricao) => await _serviceCollection.Find(x => x.Placa_Veiculo == descricao).FirstOrDefaultAsync();

        public async Task CreateAsync(Veiculos createModel) => await _serviceCollection.InsertOneAsync(createModel);

        public async Task UpdateAsync(string id, Veiculos updateModel) => await _serviceCollection.ReplaceOneAsync(x => x.Id_Veiculo == id, updateModel);

        public async Task RemoveAsync(string id) => await _serviceCollection.DeleteOneAsync(x => x.Id_Veiculo == id);
    }
}
