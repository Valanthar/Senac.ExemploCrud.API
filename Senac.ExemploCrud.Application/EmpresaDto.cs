using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ExemploCrud.Application
{
    public record CriaEmpresaDto
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }   
    }
}
