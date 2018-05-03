using SQLite;

namespace Cadastro.Models
{
    public class Cadastro
    {
        [PrimaryKey,AutoIncrement]
        private int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Regiao { get; set; }
        public string Renda { get; set; }
        public string RendaFamiliar { get; set; }

        public override string ToString()
        {
            return $"{Nome};{Telefone};{Email};{CPF};{RG};{Regiao};{Renda};{RendaFamiliar}";
        }
    }
}
