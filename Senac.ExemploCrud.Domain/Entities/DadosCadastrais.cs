namespace Senac.ExemploCrud.Domain.Entities
{
    public abstract class DadosCadastrais
    {
        public Guid Id { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
