using CRMobil.Entities.Cliente;

namespace CRMobil.Interfaces
{
    public interface IClientesServices
    {
        Task<List<Clientes>> GetAsync();

        Task<Clientes?> GetAsync(string id);

        Task<Clientes?> GetCpfCnpjAsync(string documento);

        Task<Clientes?> GetByIdAsync(string id);

        Task CreateAsync(Clientes createModel);

        Task UpdateAsync(string id, Clientes updateModel);

        Task RemoveAsync(string id);

        void Dispose();
    }
}
