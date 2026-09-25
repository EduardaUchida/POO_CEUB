namespace WebApiExemplosPOOESW.Model
{
    public class Pedido
    {
        // Atributos 

        private int id;

        private int funcionarioId;

        private int clienteId;

        private DateTime dataPedido;

        private double valorTotal;

        public Pedido()
        {

        }

        public int Id { get => id; set => id = value; }
        public int FuncionarioId { get => funcionarioId; set => funcionarioId = value; }
        public int ClienteId { get => clienteId; set => clienteId = value; }
        public DateTime DataPedido { get => dataPedido; set => dataPedido = value; }
        public double ValorTotal
        {
            get => valorTotal;

        }
        public void RegistrarVenda()
        {
            //Registra no banco de dados
        }
        public string ListarVenda()
        {
            return "Lista de Vendas";
        }
    }
}