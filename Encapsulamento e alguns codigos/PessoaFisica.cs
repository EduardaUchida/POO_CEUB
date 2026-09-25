namespace WebApiExemplosPOOESW.Model
{
    public class PessoaFisica : Pessoa // herança da classe Pessoa
    {
        public string Cpf { get; set; } // auto propriedade
        public DateTime DataNascimento { get; set; } // auto propriedade
        public string Sexo { get; set; } // auto propriedade
    }
}
