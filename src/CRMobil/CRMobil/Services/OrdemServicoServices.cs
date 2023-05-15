using CRMobil.Entities.Cliente;
using CRMobil.Entities;
using CRMobil.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using CRMobil.Entities.OrdemServico;

namespace CRMobil.Services
{
    public class OrdemServicoServices : IOrdemServicoServices
    {
        private readonly IMongoCollection<OrdemServico> _serviceCollection;

        public OrdemServicoServices(IOptions<CnnStoreDatabaseSettings> serviceCollection)
        {
            var mongoCollection = new MongoClient(serviceCollection.Value.ConnectionString);

            var mongoDatabase = mongoCollection.GetDatabase(serviceCollection.Value.DatabaseName);

            _serviceCollection = mongoDatabase.GetCollection<OrdemServico>("Ordem_Servico");
        }

        public async Task<List<OrdemServico>> GetAsync() => await _serviceCollection.Find(_ => true).ToListAsync();

        //public async Task<OrdemServico?> GetAsync(string id) => await _serviceCollection.Find(x => x.Numero_Ordem_Servico == id).FirstOrDefaultAsync();

        public async Task<OrdemServico?> GetNumeroOSAsync(string documento) => await _serviceCollection.Find(x => x.Numero_Ordem_Servico == documento).FirstOrDefaultAsync();

        public async Task CreateAsync(OrdemServico newCliente) => await _serviceCollection.InsertOneAsync(newCliente);

        public async Task UpdateAsync(string id, OrdemServico updateCliente) => await _serviceCollection.ReplaceOneAsync(x => x.Numero_Ordem_Servico == id, updateCliente);

        public async Task RemoveAsync(string id) => await _serviceCollection.DeleteOneAsync(x => x.Numero_Ordem_Servico == id);

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
