namespace WebApiExemplosPOOESW.Model
{
    public class Funcionario
    {
        // Atributos 
        // Uso de AutoPropriedades 
        public int id { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; protected set; }
        public DateTime DataAdimissao { get; set; }


        //public int Id { get => id; set => id = value; }
        //public string Nome { get => nome; set => nome = value; }
        //public string Cpf { get => cpf; set => cpf = value; }
        //public string Email { get => email; set => email = value; }
        //public string Cargo { get => cargo; set => cargo = value; }
        //double Salario { get => salario; set => salario = value; }
        //public DateTime DataAdimissao { get => dataAdimissao; set => dataAdimissao = value; }

        public virtual void CalcularSalario(int horasTrabalhadas)
        {
            Salario = horasTrabalhadas * 100;
        }

        public virtual double CalcularBonificacao()
        {
            return Salario*0.1;
        }

        //metodo oara exibir dados da classe (polimorfismo dinamico)
        public override string ToString()
        {
            return $"DADOS DO FUNCIONÁRIO\r\n" +
                   $"Nome: {Nome}\r\n" +
                   $"CPF: {Cpf}\r\n" +
                   $"Salário: R${Salario}\r\n" +
                   $"Bonificação: {CalcularBonificacao}\r\n";



        }

        public void Adicionar()
        {
            //Adicionar registro no BD
        }

        public void Excluir()
        {

        }
        public void Alterar()
        {

        }
        public string PesquisarPorid(int id)
        {
            return "";
        }
    }
}
