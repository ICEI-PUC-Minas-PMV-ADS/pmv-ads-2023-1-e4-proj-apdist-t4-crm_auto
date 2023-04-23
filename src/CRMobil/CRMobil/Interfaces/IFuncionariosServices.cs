using CRMobil.Entities.Funcionarios;

namespace CRMobil.Interfaces
{
    public interface IFuncionariosServices
    {
        Task<List<Funcionarios>> GetAsync();

        Task<Funcionarios?> GetAsync(string id);

        Task<Funcionarios> GetCpfAsync(string documento);

        Task CreateAsync(Funcionarios createModel);

        Task UpdateAsync(string id, Funcionarios updateModel);

        Task RemoveAsync(string id);

        void Dispose();
    }
}
