using System;

class Funcionário{
 
  private string _Nome;
  public string Nome{
    get { 
      return _Nome; 
    }
    set { 
      _Nome = value; 
    }
  }
  
  private string _email;
  public string email{
    get { 
      return _email; }
    set { 
      _email = value; }
  }
  private double _dia;
  public double dia{
    get {
      return _dia; }
    set {
      if (value <= 0){
        _dia = 0;
        Console.WriteLine("Dia Inválido!!\n");
        //Thread.Sleep(2000);
        Environment.Exit(0);
      }
      else if (value > 32){
        _dia = 0;
        Console.WriteLine("Dia Inválido!!\n");
        //Thread.Sleep(2000);
        Environment.Exit(0);
      }
        
      else{
        _dia = value;
      }
    }
  }
  private double _mes;
  public double mes{
    get {
      return _mes; }
    set {
      if (value <= 0){
        _mes = 0;
        Console.WriteLine("Més Inválido!!\n");
        //Thread.Sleep(2000);
        Environment.Exit(0);
      }
      else if (value > 13){
        _mes = 0;
        Console.WriteLine("Més Inválido!!\n");
        //Thread.Sleep(2000);
        Environment.Exit(0);
      }
      else{
        _mes = value;
      }
    }
  }
  private double _ano;
  public double ano{
    get {
      return _ano; }
    set {
      if (value <= 00){
        _ano = 00;
        Console.WriteLine("Ano Inválido!!\n");
        //Thread.Sleep(2000);
        Environment.Exit(0);
      }
      if  (value > 23){
        _ano = 0;
        Console.WriteLine("Ano Inválido!!\n");
        //Thread.Sleep(2000);
        Environment.Exit(0);
      }
      else{
        _ano = value;
      }
    }
  }
  private string _Tel;
  public string Tel{
    get { 
      return _Tel; }
    set { 
      _Tel = value; }
  }
  public void LêDados(){

    Console.Write("\nNome....................: ");
    this.Nome = Console.ReadLine();
    //email
    Console.Write("Email...................: ");
    this.email = Console.ReadLine();
    //data
    Console.Write("Data de Nascimento...........\n ");
    Console.Write("DD: ");
    this.dia = double.Parse(Console.ReadLine());
    Console.Write("MM: ");
    this.mes = double.Parse(Console.ReadLine());
    Console.Write("YY: ");
    this.ano = double.Parse(Console.ReadLine());
    
    Console.Write("Telefone............: ");
    this.ano = double.Parse(Console.ReadLine());
  }
  public void MostraDados(){
    Console.WriteLine($"\n{this.Nome}");
    Console.WriteLine($"Email: {this.email}");
    Console.WriteLine($"Data de Nas: R${this.dia}/{this.mes}/{this.ano}");
    Console.WriteLine($"Tel: {this.Tel}");
  }
}

class Program{
  static void Main(string[] args){
    Funcionário[] CadFunc = new Funcionário[50];
    for(int i = 0; i < 5; i++){
      Funcionário x = new Funcionário();
      x.LêDados();
      CadFunc[i] = x;
    }
    Console.Clear();
    foreach(Funcionário F in CadFunc){
      F.MostraDados();
    }
    Console.ReadKey();
  }
}