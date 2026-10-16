namespace WebApiExemplosPOOESW.Model
{
    public class ContaCorrente
    {
        // Atributos 

        private int numero;
        private string titular; 
        private double saldo=1000;

        // Propriedades 

        public int Numero { get => numero; set => numero = value; }
        public string Titular { get => titular; set => titular = value; }
        public double Saldo { get => saldo; private set => saldo = value; }



        // metodo 

        public string RetornarDadosContaCorrente()
        {
            return $"Dados da conta Corrente\r\n" +
                   $"Nome do Titular: {titular}\r\n" +
                   $"Número da conta: {numero}\r\n" +
                   $"Saldo: R${saldo}";
        }
        public void Depositar(double valor)
        {
            saldo = saldo+valor;
        }

        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
    }
    
}
