using CRMobil.Entities.Oficina;
using CRMobil.Entities.ServicosOficina;
using MongoDB.Driver;

namespace CRMobil.Interfaces
{
    public interface IOficinasServices
    {

        Task<Oficinas> GetAsync();

        Task<Oficinas?> GetAsync(string id);

        Task<Oficinas?> GetCnpjAsync(string documento);

        Task CreateAsync(Oficinas createModel);

        Task UpdateAsync(Oficinas updateModel);

        Task RemoveAsync(string id);
    }
}
