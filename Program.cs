using System;

public abstract class Veiculo
{

    protected double TaxaDiaria { get; set; }

    
    public abstract double CalcularValorTotal(int numDiarias);
}

public class Carro : Veiculo
{
   
    public Carro()
    {
        TaxaDiaria = 50.0;
    }

  
    public override double CalcularValorTotal(int numDiarias)
    {
        return TaxaDiaria * numDiarias; 
    }
}
public class Moto : Veiculo
{
    public Moto()
    {
        TaxaDiaria = 25.0;
    }

    public override double CalcularValorTotal(int numDiarias)
    {
        return TaxaDiaria * numDiarias;
    }
}

class Program
{
    static void Main()
    {
        Carro meuCarro = new Carro();
        double valorCarro = meuCarro.CalcularValorTotal(10);
        Console.WriteLine($"Valor total da locação do carro para 10 diárias: R$ {valorCarro}");

        
        Moto minhaMoto = new Moto();
        double valorMoto = minhaMoto.CalcularValorTotal(10);
        Console.WriteLine($"Valor total da locação da moto para 10 diárias: R$ {valorMoto}");
    }
}
