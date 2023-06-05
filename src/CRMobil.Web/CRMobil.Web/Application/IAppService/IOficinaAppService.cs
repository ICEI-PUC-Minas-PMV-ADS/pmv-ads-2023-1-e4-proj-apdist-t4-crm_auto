using CRMobil.Web.Application.AppService;
using CRMobil.Web.Application.Validation;
using CRMobil.Web.Domain.Entities;
using CRMobil.Web.Models.Oficina;

namespace CRMobil.Web.Application.IAppService
{
    public interface IOficinaAppService
    {
        Task<ValidationAppResult> Salvar(OficinaViewModel viewModel);
    }
}
