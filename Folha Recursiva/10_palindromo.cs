using System;

class Program {
 static void Main(){
    static bool TestaPalíndromo(string P){
      if (P.Length == 1)
        return true;
      else if(P.Length < 1)
        return false;
      if (P[0] != P[P.Length - 1])
        return false;
      else
        return TestaPalíndromo(P.Substring(1, P.Length - 2));
    }
   
    string pali;
    Console.Write("Digite uma Frase: ");
    pali = Console.ReadLine();
    if (TestaPalíndromo(pali)){
      Console.WriteLine("\nÉ Palíndromo!");
    }
    else{
      Console.WriteLine("\nNão é Palíndromo!");
    }
  Console.ReadKey();
 }
}
