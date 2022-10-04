namespace Sistema_e_abstraindo_um_celular.Models;

public class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }
    
    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine("Instalando {0} no seu Iphone!", nome);
    }
}