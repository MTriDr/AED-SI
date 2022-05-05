using System;

class Program {
  static int MaiorNum (int[] Vetor, int maior) {
    int aux = 0;
    if (maior == 0){
      return Vetor[0];
    }
    else{
      aux = MaiorNum(Vetor,maior - 1);
    }
   return(aux > Vetor[maior]? aux : Vetor[maior]);
  }

  static void Main(string[] args){
    int[] Vetor = new int[20];
    int tam = Vetor.Length;
    Random x = new Random();
    int maior = 0;
    for(int i = 0; i < Vetor.Length; i++){
      Vetor[i] = x.Next(0, 50);
      Console.Write($"{Vetor[i],7}");
    }
    maior = MaiorNum(Vetor,tam -1);
    Console.Write($"\n\nMaior numero do Vetor:\n");
    Console.Write($"{maior}");
    Console.ReadKey();
  }
}