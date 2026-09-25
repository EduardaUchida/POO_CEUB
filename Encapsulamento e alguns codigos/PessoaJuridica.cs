namespace WebApiExemplosPOOESW.Model
{
    public class PessoaJuridica : Pessoa // herança da classe Pessoa
    {
        public string Cnpj { get; set; } // auto propriedade
        public string RazaoSocial { get; set; } // auto propriedade
        public string NomeFantasia { get; set; } // auto propriedade
    }
    
    
}
