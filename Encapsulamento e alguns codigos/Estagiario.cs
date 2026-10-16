namespace WebApiExemplosPOOESW.Model
{
    public class Estagiario: Funcionario
    {
        public override void CalcularSalario(int horasTrabalhadas)
        {
            Salario = horasTrabalhadas * 50;
        }
    }
}
