namespace POO.Polimorfismo.Virtual
{
    public abstract class Veiculo
    {
        public virtual void Mover()
        {
            Console.WriteLine("Como se locomove? O veiculo se movimenta");
        }
    }
}


