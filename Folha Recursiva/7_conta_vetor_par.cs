using System;

class Program {
  static void VetPar(int[] Vetor){
    Console.WriteLine("\n\nVetor de Pares: \n");
    for(int i = 0; i < Vetor.Length; i++){
      if (Vetor[i] % 2 == 0)
      Console.Write($"{Vetor[i],7}");
    }
  }
  
  static void Main(string[] args){
    int[] Vetor = new int[10];
    Random x = new Random();
    for(int i = 0; i < Vetor.Length; i++){
      Vetor[i] = x.Next(0, 50);
      Console.Write($"{Vetor[i],7}");
    }
     VetPar(Vetor);
    Console.ReadKey();
  }
}
