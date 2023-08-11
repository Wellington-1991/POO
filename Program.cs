using POO.Polimorfismo.SobreCarga;

class Program
{
	private static void Main(string[] args)
	{
		ConverterParaReal converterDolar = new ConverterParaReal();

		var ValorEmDolar01 = 15.00M;
		Console.WriteLine("Conversão de dolar para real (Decimal) : " + converterDolar.Moeda(ValorEmDolar01));

		var ValorEmDolar02 = "15";
		Console.WriteLine("Conversão de dolar para real (String) : " + converterDolar.Moeda(ValorEmDolar02));

	}
}




//Exemplo  Semaforo - Interface

//String corDaLuz = "Verde";

//Motorista motorista = new Motorista();


//if (corDaLuz == "Verde")
//{
//	motorista.Dirigir();
//}
//else if (corDaLuz == "Amrarelo")
//{
//	motorista.PrestarAtenção();

//}
//else if (corDaLuz == "Vermelho")
//{
//	motorista.Parar();
//}


//Exemplo vaiculo - Virtual

//Carro carro = new Carro("Chevrolet", "poo-1212", 4, 2023);
//Console.WriteLine($"Modelo: {carro.Fabricante}\nPlaca: {carro.Placa}\nNumero De Portas:{carro.QuantidadeDePortas}\nAno de fabricação: {carro.AnoDeFabricacao}");

//carro.Mover();