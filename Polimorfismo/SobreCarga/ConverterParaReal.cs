namespace POO.Polimorfismo.SobreCarga
{
	internal class ConverterParaReal
	{
		private decimal _real = 4.9M;

		public decimal Moeda(decimal valor)
		{
			var valorDecimal =  (decimal)(Convert.ToDecimal(valor) * _real);

			return valorDecimal;
		}

		public string Moeda(string valor)
		{
			var valorString = (decimal)(Convert.ToDecimal(valor) * _real);

			return valorString.ToString();
		}
	}
}
