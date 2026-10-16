using Microsoft.AspNetCore.Mvc;
using WebApiExemplosPOOESW.Model;

namespace WebApiExemplosPOOESW.Controllers
{
    public class ExemploHerancaPessoaController : Controller
    {

        [HttpGet("RetornaDadosPessoa")]
        public string RetornaDadosPessoa(string nomePessoa, string enderecoPessoa,
                                 string telefonePessoa, string emailPessoa) // método que recebe os parâmetros do tipo string e retorna uma string
        {
            Pessoa pessoa = new Pessoa(); // instanciando a classe Pessoa

            pessoa.Nome = nomePessoa; // atribuindo os valores dos parâmetros aos atributos da classe Pessoa
            pessoa.Endereco = enderecoPessoa; // atribuindo os valores dos parâmetros aos atributos da classe Pessoa
            pessoa.Telefone = telefonePessoa; // atribuindo os valores dos parâmetros aos atributos da classe Pessoa
            pessoa.Email = emailPessoa; // atribuindo os valores dos parâmetros aos atributos da classe Pessoa

            return pessoa.RetornarDadosPessoa();
        }


        [HttpGet("RetornaDadosPessoaFisica")]
        public string RetornaDadosPessoaFisica(
        string nomePessoa, // parâmetro do método
        string enderecoPessoa, // parâmetro do método
        string telefonePessoa, // parâmetro do método
        string emailPessoa, // parâmetro do método
        string cpfPessoaFisica, // parâmetro do método
        DateTime dataNascimentoPessoa, // parâmetro do método
        string sexoPessoa // parâmetro do método
        ) 

        {
            PessoaFisica pessoaFisica = new PessoaFisica(); // instanciando a classe PessoaFisica

            pessoaFisica.Nome = nomePessoa; // atribuindo os valores dos parâmetros aos atributos da classe PessoaFisica
            pessoaFisica.Endereco = enderecoPessoa; // atribuindo os valores dos parâmetros aos atributos da classe PessoaFisica
            pessoaFisica.Telefone = telefonePessoa; // atribuindo os valores dos parâmetros aos atributos da classe PessoaFisica
            pessoaFisica.Email = emailPessoa; // atribuindo os valores dos parâmetros aos atributos da classe PessoaFisica
            pessoaFisica.Cpf = cpfPessoaFisica; // atribuindo os valores dos parâmetros aos atributos da classe PessoaFisica
            pessoaFisica.DataNascimento = dataNascimentoPessoa; // atribuindo os valores dos parâmetros aos atributos da classe PessoaFisica
            pessoaFisica.Sexo = sexoPessoa; // atribuindo os valores dos parâmetros aos atributos da classe PessoaFisica

            return pessoaFisica.RetornarDadosPessoa();
        }
    }

    public class ExemploHerancaPessoaJuridicaController : Controller
    {
        [HttpGet("RetornaDadosPessoaJuridica")]
        public string RetornaDadosPessoaJuridica(
            string nomePessoa,
            string enderecoPessoa,
            string telefonePessoa,
            string emailPessoa,
            string cnpjPessoa,
            string razaoSocialPessoa,
            string nomeFantasiaPessoa)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();   // instanciando a classe PessoaJuridica


            pessoaJuridica.Nome = nomePessoa; // atribuindo os valores dos parâmetros aos atributos da classe PessoaJuridica
            pessoaJuridica.Endereco = enderecoPessoa;// atribuindo os valores dos parâmetros aos atributos da classe PessoaJuridica
            pessoaJuridica.Telefone = telefonePessoa; // atribuindo os valores dos parâmetros aos atributos da classe PessoaJuridica
            pessoaJuridica.Email = emailPessoa; // atribuindo os valores dos parâmetros aos atributos da classe PessoaJuridica
            pessoaJuridica.Cnpj = cnpjPessoa; // atribuindo os valores dos parâmetros aos atributos da classe PessoaJuridica
            pessoaJuridica.RazaoSocial = razaoSocialPessoa; // atribuindo os valores dos parâmetros aos atributos da classe PessoaJuridica
            pessoaJuridica.NomeFantasia = nomeFantasiaPessoa; // atribuindo os valores dos parâmetros aos atributos da classe PessoaJuridica

            return pessoaJuridica.RetornarDadosPessoa();
        }
    }


}
