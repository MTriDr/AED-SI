using System;

class Program {
  static void sequen(string n,int a){
    int soma = 0;
    Console.WriteLine("\nSequecia : ");
    for (int i = 1; i <= a; i++){
      if(i==1){
        soma = 1;
        Console.Write($"{i}");
      }
      else if(i % 2==0){
        soma += i;
        Console.Write($" + {i}");
      }
      else{
        soma -= i;
        Console.Write($" - {i}");
      }     
    }
    Console.Write($" = {soma}");
  }
  
  public static void Main (string[] args) {
    int a;
    Console.WriteLine ("Insira o numero máximo");
    a = int.Parse(Console.ReadLine());
    string n="";    
    sequen(n,a);    
    Console.ReadLine();
  }
}