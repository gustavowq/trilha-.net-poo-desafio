using System.Security.AccessControl;
using System.Threading.Tasks.Dataflow;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {   
            Console.WriteLine("Abrindo play Store");
            Console.WriteLine(" Qual app deseja instalar?");
            nomeApp = Console.ReadLine();
            Console.WriteLine("Iniciando donwload...");
            Console.WriteLine($"O aplicativo{nomeApp} foi instalado");

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}