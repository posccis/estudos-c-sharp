using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
       static List<Conta> listcontas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                    Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
                Console.WriteLine("Obrigado por utilizar nossos serviços.");
                //Console.ReadLine();
                
            }
            
            
        }

        private static void Transferir()
        {
            Console.WriteLine();
            Console.Write("Numero da sua conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Numero da conta destino: ");
            int indiceContaD = int.Parse(Console.ReadLine());

            Console.Write("Valor a ser tranferido: ");
            int Valor = int.Parse(Console.ReadLine());

            listcontas[indiceConta].Tranferencia(Valor, listcontas[indiceContaD]);
        }

        private static void Depositar()
        {
            Console.WriteLine();
            Console.WriteLine("Numero da Conta: ");
            int indiceConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor a ser depositado: ");
            double Valor = double.Parse(Console.ReadLine());

            listcontas[indiceConta].Depositar(Valor);
        }

        private static void Sacar()
        {
            Console.WriteLine();
            Console.Write("Numero da Conta: ");
            int indiceConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor a ser sacado: ");
            double Valor = double.Parse(Console.ReadLine());
            listcontas[indiceConta].Sacar(Valor);


        }

        private static void ListarContas()
        {
            Console.WriteLine("Lista de Contas: ");
            if (listcontas.Count == 0)
            {
                Console.WriteLine("Ainda não há nenhuma conta.");
                return;
            }
            for (int i = 0; i < listcontas.Count; i++)
            {
                Conta conta = listcontas[i];
                Console.WriteLine("#{0} - ", i);
                Console.WriteLine(conta);

            }
        }

        private static void InserirConta()
        {
            Console.WriteLine();
            Console.WriteLine("Inserir uma nova conta");

            Console.WriteLine("Qual o tipo da conta?\n1 - Pessoa Fisica\n2 - Pessoa Juridica");
            int entTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Nome do cliente: ");
            string entNome = Console.ReadLine();

            Console.Write("Saldo Inicial: ");
            double entSaldo = double.Parse(Console.ReadLine());

            Console.Write("Informe o credito: ");
            double entCredito = double.Parse(Console.ReadLine());
            
            Conta novaConta = new Conta(tipoConta: (TipoConta)entTipoConta,
                                        saldo: entSaldo,
                                        credito: entCredito,
                                        nome: entNome
            );
            listcontas.Add(novaConta);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Bem Vindo aos nossos sistemas!");
            Console.WriteLine("Informe o serviço desejado:");
            Console.WriteLine("1 - Ver lista de contas \n2 - Inserir uma nova conta \n3 - Fazer uma transferencia \n4 - Saque \n5 - Deposito \nC - Limpar a tela \n X - Sair");
            string opcao = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcao;
        }
    }
}
