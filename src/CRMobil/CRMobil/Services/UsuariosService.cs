using CRMobil.Entities.Cliente;
using CRMobil.Entities;
using CRMobil.Entities.Usuarios;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using CRMobil.Interfaces;

namespace CRMobil.Services
{
    public class UsuariosService : IUsuariosService
    {
        private readonly IMongoCollection<Usuarios> _userServiceCollection;
        
        protected readonly ILogger _logger;

        public UsuariosService(IOptions<CnnStoreDatabaseSettings> serviceCollection)
        {
            var mongoCollection = new MongoClient(serviceCollection.Value.ConnectionString);

            var mongoDatabase = mongoCollection.GetDatabase(serviceCollection.Value.DatabaseName);

            _userServiceCollection = mongoDatabase.GetCollection<Usuarios>("Usuarios");
        }

        public async Task<string> CreateUser(Usuarios userModel)
        {
            try
            {
                if (userModel is null)
                {
                    return null;
                }

                var hash = SecurePasswordHasher.Hash(userModel.Senha);

                userModel.Senha = hash;

                await _userServiceCollection.InsertOneAsync(userModel);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Falha: {nameof(UsuariosService)}; {nameof(CreateUser)}; {ex.Message};");
            }

            return $"Usuario '{userModel.Nome_Usuario}' cadastrado com sucesso";
        }

        public async Task<List<Usuarios>> GetAsync()
        {
            return await _userServiceCollection.Find(_ => true).ToListAsync();
        }

        public async Task<Usuarios?> Login(string userName, string userPassword)
        {
            var usuario = new Usuarios();
            usuario = await _userServiceCollection.Find(x => x.Nome_Usuario == userName).FirstOrDefaultAsync();

            if (SecurePasswordHasher.Verify(userPassword, usuario.Senha))
            {
                return usuario;
            }

            return null;

            //return await _userServiceCollection.Find(x => x.Nome_Usuario == userName).FirstOrDefaultAsync();
        }        
    }
}
