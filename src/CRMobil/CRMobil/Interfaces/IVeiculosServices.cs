using CRMobil.Entities.Veiculos;

namespace CRMobil.Interfaces
{
    public interface IVeiculosServices
    {

        Task<List<Veiculos>> GetAsync();

        Task<Veiculos?> GetAsync(string id);

        Task<Veiculos> GetPlacaAsync(string descricao);

        Task CreateAsync(Veiculos createModel);

        Task UpdateAsync(string id, Veiculos updateModel);

        Task RemoveAsync(string id);
    }
}
