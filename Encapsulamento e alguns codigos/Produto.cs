using System.Reflection.Metadata;

namespace WebApiExemplosPOOESW.Model
{
    // Atributos 
    public class Produto
    {
        private int id;

        private string nome;

        private string descricao;

        private int quantidadenoestoque;

        private double precoUnitario;

        private Blob imagemProduto;

        public Produto()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Quantidadenoestoque { get => quantidadenoestoque; set => quantidadenoestoque = value; }
        public double PrecoUnitario { get => precoUnitario; set => precoUnitario = value; }
        public Blob ImagemProduto { get => imagemProduto; set => imagemProduto = value; }

      
    public void Excluir(int id)
        {
            //adicionar banco
        }
        public void Alterar(int id)
        {

        }
        public string PesquisarProdutoporid(int id)
        {
            return "Retorna produto por id";
        }
        public string ListaTodosProdutos()
        {
            return "Retorna todos os produtos";
        }
    }
} 
