namespace Concessionaria
{
    public class Moto:Veiculo
    {
        public int Cilindrada { get; set; }
        public string Partida { get; set; }
         public Moto(string marca, string modelo, DateTime ano, int quilometragem, string cor, double valor, int cilindrada, string partida) : base(marca, modelo, ano, quilometragem, cor, valor)
        {
            SetCilindrada(cilindrada);
            SetPartida(partida);
        }
        public void SetCilindrada(int cilindrada)
        {
            Cilindrada=cilindrada;
        }
        public int GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetPartida(string partida)
        {
            Partida=partida;
        }
        public string GetPartida()
        {
            return Partida;
        }
    }
}