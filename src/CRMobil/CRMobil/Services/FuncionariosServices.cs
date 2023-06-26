using CRMobil.Entities;
using CRMobil.Entities.Funcionarios;
using CRMobil.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CRMobil.Services
{
    public class FuncionariosServices : IFuncionariosServices
    {
        private readonly IMongoCollection<Funcionarios> _serviceCollection;

        public FuncionariosServices(IOptions<CnnStoreDatabaseSettings> serviceCollection)
        {
            var mongoCollection = new MongoClient(serviceCollection.Value.ConnectionString);

            var mongoDatabase = mongoCollection.GetDatabase(serviceCollection.Value.DatabaseName);

            _serviceCollection = mongoDatabase.GetCollection<Funcionarios>("Funcionarios");
        }

        public async Task<List<Funcionarios>> GetAsync() => await _serviceCollection.Find(_ => true).ToListAsync();

        public async Task<Funcionarios?> GetAsync(string id) => await _serviceCollection.Find(x => x.Id_Funcionario == id).FirstOrDefaultAsync();

        public async Task<Funcionarios> GetCpfAsync(string documento) => await _serviceCollection.Find(x => x.Cpf == documento).FirstOrDefaultAsync();

        public async Task CreateAsync(Funcionarios newFuncionario) => await _serviceCollection.InsertOneAsync(newFuncionario);

        public async Task UpdateAsync(string id, Funcionarios updateFuncionario) => await _serviceCollection.ReplaceOneAsync(x => x.Id_Funcionario == id, updateFuncionario);

        public async Task RemoveAsync(string id) => await _serviceCollection.DeleteOneAsync(x => x.Id_Funcionario == id);

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
