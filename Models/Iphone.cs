namespace DesafioPOO.Models
{
    // implementado
    public class Iphone : Smartphone
    {
        public Iphone(String numero, string modelo, string imei, int memoria ):base(numero, modelo, imei, memoria)
        {
            
        }
        // implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando {nomeApp} no Iphone");
        }
    }
}