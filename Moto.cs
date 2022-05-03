namespace Concessionaria
{
    public class Moto
    {
        public int Cilindrada { get; set; }
        public string Partida { get; set; }
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