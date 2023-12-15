namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
    // Correção realizada!
      public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
    public override void InstalarAplicativo(string nomeApp)
    {
        // Correção realizada!
        Console.WriteLine($"Instalação do Aplicativo {nomeApp} no iPhone.");
    }
    }
}