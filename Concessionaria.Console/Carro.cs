namespace Concessionaria
{
    public class Carro:Veiculo
    {
        public bool TransmissaoAutomatica { get; set; }
        public string Combustivel { get; set; }
        public Carro(string marca, string modelo, string ano, int quilometragem, string cor, double valor, bool transmissao, string combustivel) : base(marca, modelo, ano, quilometragem, cor, valor)
        {
            SetTransmissaoAutomatica(transmissao);
            SetCombustivel(combustivel);
            SetValor(CalcValor());
        }
        public void SetTransmissaoAutomatica(bool transmissao)
    {
        TransmissaoAutomatica=transmissao;
    }
    public bool GetTransmissaoAutomatica()
    {
        return TransmissaoAutomatica;
    }
    public void SetCombustivel(string combustivel)
    {
        Combustivel=combustivel;
    }
    public string GetCombustivel()
    {
        return Combustivel;
    }
        public override double CalcValor()
        {
            if(TransmissaoAutomatica)
            {
                double valorCalc = Valor + (Valor * 0.2);
                return valorCalc;
            }
            else
            {
                return Valor;
            }
        }
    }
    
}