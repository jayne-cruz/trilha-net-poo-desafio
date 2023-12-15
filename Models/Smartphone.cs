
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Iniciando smartphone. Aguarde...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
            Console.WriteLine("Ligação finalizada. Duração de ligação: 1 minutos e 39 segundos.");
        }

        public void MensagemDeTexto()
        {
            Console.WriteLine("Enviando mensagem de texto...");
            Console.WriteLine("Mensagem de texto enviada com sucesso!");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}