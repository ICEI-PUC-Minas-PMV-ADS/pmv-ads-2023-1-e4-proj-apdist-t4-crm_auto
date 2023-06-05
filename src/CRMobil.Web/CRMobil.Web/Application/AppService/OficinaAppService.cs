using CRMobil.Web.Application.IAppService;
using CRMobil.Web.Application.Mapper;
using CRMobil.Web.Application.Validation;
using CRMobil.Web.Domain.Entities;
using CRMobil.Web.Domain.ValueObjects;
using CRMobil.Web.Models.Oficina;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CRMobil.Web.Application.AppService
{
    public class OficinaAppService
    {
        //private readonly string apiUrl = "https://localhost:7165/api/Oficina";

        //public Task<ValidationAppResult> Salvar(OficinaViewModel viewModel)
        //{
            //var result = new ValidationResult();
            //try
            //{
            //    var oficina = OficinaMapper.ToDomain(viewModel);
            //    var oficinaResult = new Oficina();

            //    if (viewModel.Id_Oficina != null && viewModel.Id_Oficina != "0")
            //        oficinaResult = _tipoDocumentoService.Update(oficina);
            //    else
            //        oficinaResult = _tipoDocumentoService.Add(oficina);

            //    if (!oficinaResult.ResultValidation.IsValid)
            //    {
            //        return DomainToApplicationResult(oficinaResult.ResultValidation);
            //    }
            //    Commit();
            //    return DomainToApplicationResult(oficinaResult.ResultValidation);
            //}

            //catch (Exception e)
            //{
            //    result.AdicionarErro(new ValidationError("Não foi possivel salvar o registro:" + e.Message));
            //    return DomainToApplicationResult(result);
            //}

        //}

    }
}
