using CRMobil.Entities.Usuarios;

namespace CRMobil.Interfaces
{
    public interface IUsuariosService //:IServiceBase<Usuarios>
    {
        Task<string> CreateUser(Usuarios userModel);
        Task<List<Usuarios>> GetAsync();
        Task<Usuarios?> Login(string userName, string userPassaword);
    }
}
