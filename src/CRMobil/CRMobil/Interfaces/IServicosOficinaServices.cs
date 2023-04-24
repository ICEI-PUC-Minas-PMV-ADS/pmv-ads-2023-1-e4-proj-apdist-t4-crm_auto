using CRMobil.Entities.ServicosOficina;
using CRMobil.Entities.Usuarios;

namespace CRMobil.Interfaces
{
    public interface IServicosOficinaServices
    {
        Task<List<ServicosOficina>> GetAsync();

        Task<ServicosOficina?> GetAsync(string id);

        Task<ServicosOficina?> GetDescricaoAsync(string descricao);

        Task CreateAsync(ServicosOficina createModel);

        Task UpdateAsync(string id, ServicosOficina updateModel);

        Task RemoveAsync(string id);
    }
}
