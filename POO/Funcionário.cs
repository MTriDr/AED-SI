using System;

class Funcionário{
  private string _Matrícula;
  public string Matrícula{
    get { 
      return _Matrícula; }
    set { 
      _Matrícula = value; }
  }
  private string _Nome;
  public string Nome{
    get { return _Nome; }
    set { _Nome = value; }
  }
  private double _Salário;
  public double Salário{
    get {
      return _Salário; }
    set {
      if (value < 0){
        _Salário = 0;
        Console.WriteLine("Salário Inválido!!\n");
        //Thread.Sleep(2000);
        Environment.Exit(0);
      }
      else{
        _Salário = value;
      }
    }
  }
  public void LêDados(){
    Console.Write("\nMatrícula do Funcionário: ");
    this.Matrícula = Console.ReadLine();
    Console.Write("Nome....................: ");
    this.Nome = Console.ReadLine();
    Console.Write("Salário (R$)............: ");
    this.Salário = double.Parse(Console.ReadLine());
  }
  public void MostraDados(){
    Console.WriteLine($"\n{this.Nome} ({this.Matrícula})");
    Console.WriteLine($"Salário: R${this.Salário:F2}");
  }
}

class Program{
  static void Main(string[] args){
    Funcionário[] CadFunc = new Funcionário[3];
    for(int i = 0; i < 3; i++){
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
