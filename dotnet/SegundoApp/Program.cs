using System;

namespace SegundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string choice = UserChoice();
            var indiceAluno = 0;

            while (choice.ToUpper() != "X")
            {
                
                switch (choice)
                {
                    case "1":
                        
                        Console.WriteLine("Nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("A nota do aluno: ");
                        var nota = decimal.Parse(Console.ReadLine());
                        aluno.Nota = nota;
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                choice = UserChoice();
                
            }

        }

        private static string UserChoice()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Adicionar novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");

            string opcaoUser = Console.ReadLine();
            return opcaoUser;
        }
    }
}
