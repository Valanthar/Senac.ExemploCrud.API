using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ExemploCrud.Application
{
    public record CriaPessoaDto
    {
        public string Nome {get; set;}
        public string CPF { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
