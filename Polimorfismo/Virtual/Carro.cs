namespace POO.Polimorfismo.Virtual
{
    internal class Carro : Veiculo
    {
        public string? Fabricante { get; set; }
        public string Placa { get; set; }
        public int QuantidadeDePortas { get; set;}
        public int AnoDeFabricacao { get; set;}


        public Carro(string fabricante, string placa, int quantidadeDePortas, int anoDeFabricacao)
        {
            Fabricante = fabricante;
            Placa = placa;
            QuantidadeDePortas = quantidadeDePortas;
            AnoDeFabricacao = anoDeFabricacao;
        }


        public override void Mover()
        {
            Console.WriteLine("Como se locomove? O carro corre");
        }
    }
}
