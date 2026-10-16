using Microsoft.AspNetCore.Mvc;
namespace WebApiExemplosPOOESW.Model;

public class ExemploEncapsulamentoContaCorrenteController : Controller
{
    [HttpGet("SaldoContaCorrente")]

    public string SaldoContaCorrente(int numeroConta,
                                     string titulaConta)
    {
        ContaCorrente contaCorrente = new ContaCorrente();
        contaCorrente.Numero = numeroConta;
        contaCorrente.Titular = titulaConta;
        //contaCorrente.Saldo = saldoConta;

        return contaCorrente.RetornarDadosContaCorrente();
    }
    [HttpPost("EfetuarSaque")]
    public string EfetuarSaque(int numeroConta,
                                  string titulaConta,
                                  double valorSaque)
    {
        ContaCorrente contaCorrente = new ContaCorrente();
        contaCorrente.Numero = numeroConta;
        contaCorrente.Titular = titulaConta;
        if (valorSaque > contaCorrente.Saldo)
        {
            return "Você não tem Saldo suficiente";
        }
        contaCorrente.Sacar(valorSaque);
        return contaCorrente.RetornarDadosContaCorrente();
    }
}