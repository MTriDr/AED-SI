using System;
class Program {
    static int ContDig(int a){
    int cont = 1;
    if(a >=10){
      a = a/10;
      cont = cont+ContDig(a);
    }
    return cont;
  }
  public static void Main (string[] args) {
    int a;
    int aux;
    Console.WriteLine("insira o numero: ");
    a = int.Parse(Console.ReadLine());
    aux = ContDig(a);
    Console.WriteLine($"O numero de digitos de {a} = {aux}");
    Console.ReadKey();
  }
}
