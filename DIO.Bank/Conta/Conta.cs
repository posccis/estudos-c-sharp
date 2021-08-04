using System;

namespace DIO.Bank
{
    public class Conta
    {
        private TipoConta TipoConta {get; set;}
        private double Saldo {get; set;}
        private double Credito {get; set;}
        public string Nome{get; set;}

/*Metodo construtor da conta*/
        public Conta (TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;

        }
/*---*/

/*Metodo para sacar algum valor*/
        public bool Sacar(double ValorSaque)
        {
            if (this.Saldo - ValorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.Saldo -= ValorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            return true;
        }
/*---*/

/*Metodo para depositar*/
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }
/*---*/

        public void Tranferencia(double valorTranferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTranferencia)){
                contaDestino.Depositar(valorTranferencia);
            }
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Tipo da conta: " + this.TipoConta + " | ";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Saldo: " + this.Saldo + " | ";
            retorno += "Credito: " + this.Credito;
            return retorno; 
        }

    }
}