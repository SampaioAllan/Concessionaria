using Concessionaria.MinhasExceptions;

namespace Concessionaria
{
    public class Moto:Veiculo
    {
        private int Cilindrada { get; set; }
        private string Partida { get; set; }
         public Moto(string marca, string modelo, string ano, int quilometragem, string cor, double valor, int cilindrada, string partida) : base(marca, modelo, ano, quilometragem, cor, valor)
        {
            SetCilindrada(cilindrada);
            SetPartida(partida);
            SetValor(CalcValor());
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
        public override double CalcValor()
        {
            double valorCalc = Cilindrada * 50;
            if (Partida=="injeção eletrônica")
            {
                valorCalc= valorCalc + (valorCalc * 0.1);
            }
            return valorCalc;
        }

        public override bool ValidarValor(double valor)
        {
            if (valor >= 2000)
            {
                return true;
            }
            throw new ValidacaoDeDados("Valor inválido!");
        }
    }
}