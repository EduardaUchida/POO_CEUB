//Declaração Variaveis
using System.ComponentModel.Design;

int idade;
string classificacaoFaixaEtaria = "", situacaoVoto = "";

//ENTRADA
Console.WriteLine("Informe sua Idade");
idade = Convert.ToInt32(Console.ReadLine());

//PROCESSAMENTO
if ((idade == 0) && (idade < 13))
{
    classificacaoFaixaEtaria = "Classsificação: CRIANÇA";
    situacaoVoto = "VOTO PROIBIDO";
}
else if ((idade >= 13) && (idade <= 17));
{
    classificacaoFaixaEtaria = "Classificação: ADOLESCENTE";
    if ((idade >= 16) && (idade <= 17))
    {
        situacaoVoto = "VOTO FACULTATIVO";
    }
    else
    { situacaoVoto = "VOTO PROIBIDO";
    }
}
else if ((idade > 17) && (idade <=59))
{
    classificacaoFaixaEtaria = "classificação: ADULTO";
    situacaoVoto = "VOTO OBRIGATORIO"; 
}
else
{
    classificacaoFaixaEtaria = "Classificação: IDOSO";
    situacaoVoto = "VOTO FACULTATIVO";
}
Console.WriteLine($"A idade da pessoa é:{idade} anos");
Console.WriteLine(classificacaoFaixaEtaria);
Console.WriteLine($"Situação do Voto:{situacaoVoto}");