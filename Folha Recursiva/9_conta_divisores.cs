using System;

class Program {
  static int ContaDiv(int i, int n){
    int aux=0;
    if (i <= n){
      if (n % i == 0){
      aux = aux + 1 + ContaDiv(i + 1, n);
      Console.Write($"{i} ");
      }
      else
      aux = aux + 0 + ContaDiv(i + 1, n);
    }
   return aux;
  }
  static void Main(){
    int n;
    int Div;
    Console.Write("n = ");
    n = int.Parse(Console.ReadLine());
    Console.Write($"Divisores: ");
    Div = ContaDiv(1,n);
    Console.WriteLine($"\nNumero de Divisores: {Div}");
    Console.ReadKey();
  }
}
