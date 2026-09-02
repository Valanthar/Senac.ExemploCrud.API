using Microsoft.AspNetCore.Mvc;
using Senac.ExemploCrud.Domain.Entities;
using Senac.ExemploCrud.Application;

namespace Senac.ExemploCrud.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmpresaController
    {
        [HttpPost]
        public bool CriarEmpresa([FromBody] CriaEmpresaDto dto)
        {
            Empresa obj = new Empresa(dto.RazaoSocial, dto.CNPJ, dto.Email, dto.Telefone);
            return true;
        }

    }
}

        