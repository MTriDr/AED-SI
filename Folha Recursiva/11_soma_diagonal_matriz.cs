using System;

class Program {
  static int Diagonal(int[,] M, int pos){    
    int soma = 0;
    if (pos > 0){
      soma = M[pos - 1, pos - 1];
      soma += Diagonal(M, pos - 1);
    }

    return soma;
  }
  
  static void Mostra(int[,] M, int i, int j){
    int Linhas = M.GetLength(0);
    int Colunas = M.GetLength(1);
    if (i < Linhas && j < Colunas){
      Console.Write($"{M[i, j],6}");
      j++;
      Mostra(M, i, j);
    }
    else if (i < Linhas && j == Colunas){
      i++;
      j = 0;
      Console.WriteLine("\n");
      Mostra(M, i, j);
    }
  }
  
  static void Main(string[] args){
    Random x = new Random();
    int[,] Matriz = new int[4, 4];
    for (int i = 0; i < 4; i++){
      for (int j = 0; j < 4; j++){
        Matriz[i, j] = x.Next(0, 30);
      }
    }
    Mostra(Matriz, 0, 0);

    int soma = Diagonal(Matriz, 4);

    Console.WriteLine($"\nSoma da diagonal= {soma}");
    Console.ReadKey();
  }
}
