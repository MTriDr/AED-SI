using System;

class Program {
  public static string reverseStrings(string Nome){
    if(Nome.Length > 0){
      return Nome[Nome.Length - 1] + reverseStrings(Nome.Substring(0, Nome.Length - 1));
    } else return Nome;
  }  
  static void Main(string[] args){
    string Nome;
    string reverseString;
    Console.Write("Digite um Nome: ");
    Nome = Console.ReadLine();
    reverseString = reverseStrings(Nome);
    
    Console.WriteLine($"\nNome Invertido: {reverseString} ");
    Console.ReadKey();
  }
}