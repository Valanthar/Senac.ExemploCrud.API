namespace Senac.ExemploCrud.Domain.Entities
{
    public class Pessoa : DadosCadastrais
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public DateTime? DataNascimento { get; private set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, string cpf, 
            DateTime? dataNascimento, string email, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
            Id = Guid.NewGuid();
        }
    }
}
