namespace DesafioPOO.Models
{
    // Correção realizada!
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        // Correção realizada!

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalação do Aplicativo {nomeApp} no iPhone.");
        }
    }
}