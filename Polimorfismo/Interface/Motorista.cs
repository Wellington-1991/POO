namespace POO.Polimorfismo.Interface
{
	public class Motorista : ISemaforo
	{
		public void Dirigir()
		{
			Console.WriteLine("Semaforo Aberto: Continue Digirigindo tranquilamente");
		}

		public void Parar()
		{
			Console.WriteLine("Semaforo fechado: Pare na faixa");
		}

		public void PrestarAtenção()
		{
			Console.WriteLine("Semaforo vai fechar: Prossiga, mais preste atenção");
		}
	}
}
