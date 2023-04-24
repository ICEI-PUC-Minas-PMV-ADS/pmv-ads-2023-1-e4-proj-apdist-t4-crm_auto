using CRMobil.Entities.Cliente;
using CRMobil.Entities.OrdemServico;

namespace CRMobil.Interfaces
{
    public interface IOrdemServicoServices
    {
        Task<List<OrdemServico>> GetAsync();

        Task<OrdemServico?> GetAsync(string id);

        Task CreateAsync(OrdemServico createModel);

        Task UpdateAsync(string id, OrdemServico updateModel);

        Task RemoveAsync(string id);

        void Dispose();
    }
}
