namespace Sistema_e_abstraindo_um_celular.Models;

public abstract class Smartphone
{
    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string IMEI { get; set; }
    private int Memoria { get; set; }

    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        this.Numero = numero;
        this.Modelo = modelo;
        this.IMEI = imei;
        this.Memoria = memoria;
    }
    

    public void Ligar()
    {
        Console.WriteLine("Ligando!");
    }

    public void ReceberLigação()
    {
        Console.WriteLine("Recebendo ligação!");
    }

    public abstract void InstalarAplicativo(string nome);
}