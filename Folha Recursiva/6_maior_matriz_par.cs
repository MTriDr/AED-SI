using System;

class Program {
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
  
 static int MaiorNum (int[,] M, int l, int c){
    int maior = 0;    
    for(int i = 0; i < l; i++){
      for(int j = 0; j < c; j++){
        if(M[i, j] % 2 == 0 && M[i, j] > maior){
          maior = M[i, j];
        }
      }
    }
    return maior;
  }
  
  static void Main(string[] args){
    Random x = new Random();
    int[,] Matriz = new int[3, 4];
    int maior =0;
    for (int i = 0; i < 3; i++){
      for (int j = 0; j < 4; j++){
        Matriz[i, j] = x.Next(0, 30);
      }
    }
    Mostra(Matriz, 0, 0);   
    int linha = 3, coluna = 4;
    maior= MaiorNum(Matriz, linha, coluna);
    Console.WriteLine($"\nMaior valor par = {maior}");
    Console.ReadKey();
  }
}
