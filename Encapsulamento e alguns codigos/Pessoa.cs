namespace WebApiExemplosPOOESW.Model
{
    public class Pessoa
    {
        // Atributos 
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public string RetornarDadosPessoa()
        {
            return $"Dados da Pessoa\r\n" +
                   $"NomePessoa: {Nome}\r\n" +
                   $"Endereço: {Endereco}\r\n" +
                   $"Telefone: {Telefone}\r\n" +
                   $"E-mail: {Email}";
        }
    }
}
