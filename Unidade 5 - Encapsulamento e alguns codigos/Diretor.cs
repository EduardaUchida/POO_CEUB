namespace WebApiExemplosPOOESW.Model
{
    public class Diretor: Funcionario
    {
        public override void CalcularSalario(int horasTrabalhadas)
        {
            Salario = horasTrabalhadas * 200;
        }
    }
}
