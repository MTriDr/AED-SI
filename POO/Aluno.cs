static void Main()
{
    string[] Nomes = new string[5];
    int[,] Notas = new int[5, 3];

    // Entrada de Dados

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"\nNome do Aluno {i + 1}......: ");
        Nomes[i] = Console.ReadLine();

        for (int j = 0; j < 3; j++)
        {
            Console.Write($"   => Nota da Prova {j + 1}: ");
            Notas[i, j] = int.Parse(Console.ReadLine());
        }
    }

    Console.Clear();

    // Nota Final de cada Aluno

    int Soma;
    double Média;

    for (int i = 0; i < 5; i++)
    {
        Soma = 0;

        for (int j = 0; j < 3; j++)
        {
            Soma += Notas[i, j];
        }

        Console.WriteLine($"{Nomes[i]}{Soma,20}");
    }

    Console.WriteLine("\n\n");

    // Média das Notas em cada Prova

    for (int i = 0; i < 3; i++)
    {
        Soma = 0;

        for (int j = 0; j < 5; j++)
        {
            Soma += Notas[j, i];
        }

        Média = (double)Soma / 5;

        Console.WriteLine($"Média da Prova {i + 1}: {Média:F2}");
    }

    Console.ReadKey();
}