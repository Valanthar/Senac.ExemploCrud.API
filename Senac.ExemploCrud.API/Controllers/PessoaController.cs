using Microsoft.AspNetCore.Mvc;
using Senac.ExemploCrud.Domain.Entities;
using Senac.ExemploCrud.Application;

namespace Senac.ExemploCrud.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoaController
    {
        [HttpPost]
        public bool CriarPessoa([FromBody] CriaPessoaDto dto)
        {
            //Montando objeto SOMENTE para teste
            Pessoa obj = new Pessoa(dto.Nome,dto.CPF,dto.DataNascimento,dto.Email, dto.Telefone);
            return true;
        }
    }
}
    