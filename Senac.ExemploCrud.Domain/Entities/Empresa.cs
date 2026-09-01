using System.Globalization;

namespace Senac.ExemploCrud.Domain.Entities
{
    public class Empresa : DadosCadastrais
    {
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }

        public Empresa()
        {

        }
        public Empresa(string razaoSocial, string cnpj, 
            string telefone, string email)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            Telefone = telefone;
            Email = email;
            Id = Guid.NewGuid();
        }
    }
}
