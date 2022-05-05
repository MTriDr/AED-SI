using System;

class Program {
  static int Pot(int a, int b){
    if (b == 0)
      return 1;
    else
      return a * Pot(a, b - 1);
  }
  static void Main(){
    int x, y;
    int aux;
    Console.Write("x = ");
    x = int.Parse(Console.ReadLine());
    Console.Write("y = ");
    y = int.Parse(Console.ReadLine());
    aux = Pot(x, y);
    Console.WriteLine($"\nA potencia de {x}^{y} = {aux}");
    Console.ReadKey();
  }
}
