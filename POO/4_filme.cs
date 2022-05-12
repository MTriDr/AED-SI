using System;

class Filme {
  // Variáveis
  private int _duracao;
  private string _nome;
  private string _diretor;
  private string _categoria;

  // Get e Set Duração
  public int Duracao {
    get {
      return this._duracao;
    }
    set {
      _duracao = value;
    }
  }

  // Get e Set Nome
  public string Nome {
    get {
      return this._nome;
    }
    set {
      _nome = value;
    }
  }

  // Get e Set Diretor
  public string Diretor {
    get {
      return this._diretor;
    }
    set {
      _diretor = value;
    }
  }

  // Get e Set Categoria
 public string Categoria {
    get {
      return this._categoria;
    }
    set {
      _categoria = value;
    }
  }
  
  // Lê Dados
  public void Leitura () {
    Console.Write("\nNome....................: ");
    this.Nome = Console.ReadLine();

    Console.Write("Duracao.................: ");
    this.Duracao = int.Parse(Console.ReadLine());

    Console.Write("Diretor.................: ");
    this.Diretor = Console.ReadLine();

    Console.Write("Categoria...............: ");
    this.Categoria = Console.ReadLine();
  }

  // Mostrar Dados
  public void Imprime () {
    Console.WriteLine($"\nNome do filme:{this.Nome}");
    Console.WriteLine($"Diretor:{this.Diretor}");
    Console.WriteLine($"Categoria: {this.Categoria}");
    Console.WriteLine($"Duração {this.Duracao} minutos");
  }  
}

public class Program {

  public static void Main (string[] args) {
    Filme[] f = new Filme[5];

    for(int i = 0; i < 5; i++){
      Filme tmp = new Filme();
      tmp.Leitura();
      f[i] = tmp;
    }

    Console.Clear();

    foreach(Filme tmp in f){
      tmp.Imprime();
    }

    Console.Write("\n\nInsira a categoria desejada: ");
    string categoria = Console.ReadLine();

    foreach(Filme tmp in f){      
      if(String.Equals(tmp.Categoria, categoria)){
        tmp.Imprime();
      }
    }
    
    Console.ReadKey();
  }
}