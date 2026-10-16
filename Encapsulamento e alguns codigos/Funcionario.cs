namespace WebApiExemplosPOOESW.Model
{
    public class Funcionario
    {
        // Atributos 
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private string cargo;
        private double salario;
        private DateTime dataAdimissao;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario { get => salario; set => salario = value; }
        public DateTime DataAdimissao { get => dataAdimissao; set => dataAdimissao = value; }

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
