namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {
             
            Console.WriteLine("Abrindo Apple Store");
            Console.WriteLine("Iniciando donwload...");
            Console.WriteLine($"O aplicativo  {nomeApp} foi instalado");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}