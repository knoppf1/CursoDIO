using System;


namespace CursoDIO
{
    class Program
    {
        static void Main(string[] args)

        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            string opcaoUsuario = ObterOpcao();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {

                    case "1":
                        Console.WriteLine("Digite o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case "2":
                        foreach (var a in alunos)

                        if(!string.IsNullOrEmpty(a.Nome))
                        {
                        Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                        }
                        break;

                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for(int i=0; i< alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                            notaTotal = notaTotal + alunos[i].Nota;
                            nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;

                        Console.WriteLine($"MEDIA GERAL: {mediaGeral}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcao();

            }
        }





        private static string ObterOpcao()
        {
            Console.WriteLine();
            Console.WriteLine("Digite sua opção:");
            Console.WriteLine("1- Entrada de dados do Aluno");
            Console.WriteLine("2- Listagem de Alunos");
            Console.WriteLine("3- Média Geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
