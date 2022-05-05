using System;

class Program {
  static int MaiorNum(int[] Vetor, int soma){
    Console.WriteLine("\n\nMaior numero do Vetor: \n");
    for(int i = 0; i < Vetor.Length; i++){
      if (i < Vetor.Length)
      soma = soma + Vetor[i];
    }
    return soma;
  }
  
  static void Main(string[] args){
    int[] Vetor = new int[20];
    int soma = 0;
    Random x = new Random();
    for(int i = 0; i < Vetor.Length; i++){
      Vetor[i] = x.Next(0, 50);
      Console.Write($"{Vetor[i],7}");
    }
   soma= MaiorNum(Vetor,soma);
    Console.Write($"{soma}");
    Console.ReadKey();
  }
}