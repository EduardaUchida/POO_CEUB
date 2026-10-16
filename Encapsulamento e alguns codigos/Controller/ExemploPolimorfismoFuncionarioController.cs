using Microsoft.AspNetCore.Mvc;
using WebApiExemplosPOOESW.Model; 
namespace WebApiExemplosPOOESW.Controllers
{
    public class ExemploPolimorfismoFuncionarioController : Controller
    {
        [HttpPost("RetornaDadosFinanceirosDiretor")]
        public string RetornaDadosFinanceirosDiretor(string nomeFuncionario,
                                                     string cpfFuncionario,
                                                     int horasTrabalhadasFuncionario)

        {
            Diretor diretor = new Diretor();
            diretor.Nome = nomeFuncionario;
            diretor.Cpf = cpfFuncionario;
            diretor.CalcularSalario(horasTrabalhadasFuncionario);
            return diretor.ToString();

        }

        [HttpPost("RetornaDadosFinanceirosDiretor")]
        public string RetornaDadosFinanceirosEstagiario(string nomeFuncionario,
                                             string cpfFuncionario,
                                             int horasTrabalhadasFuncionario)

        {
            Estagiario estagiario = new Estagiario();
            estagiario.Nome = nomeFuncionario;
            estagiario.Cpf = cpfFuncionario;
            estagiario.CalcularSalario(horasTrabalhadasFuncionario);
            return estagiario.ToString();

        }

        [HttpPost("RetornaDadosFinanceirosGerente")]
        public string RetornaDadosFinanceirosGerente(string nomeFuncionario,
                                     string cpfFuncionario,
                                     int horasTrabalhadasFuncionario)

        {
            Gerente gerente = new Gerente ();
            gerente.Nome = nomeFuncionario;
            gerente.Cpf = cpfFuncionario;
            gerente.CalcularSalario(horasTrabalhadasFuncionario);
            return gerente.ToString();

        }


    }

}
