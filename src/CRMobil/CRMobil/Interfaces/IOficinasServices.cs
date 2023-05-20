using CRMobil.Entities.Oficina;
using CRMobil.Entities.ServicosOficina;

namespace CRMobil.Interfaces
{
    public interface IOficinasServices
    {

        Task<Oficinas> GetAsync();

        Task<Oficinas?> GetAsync(string id);

        Task<Oficinas?> GetCnpjAsync(string documento);

        Task CreateAsync(Oficinas createModel);

        Task UpdateAsync(string id, Oficinas updateModel);

        Task RemoveAsync(string id);
    }
}
