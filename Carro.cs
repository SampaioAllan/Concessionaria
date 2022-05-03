namespace Concessionaria
{
    public class Carro
    {
        public bool TransmissaoAutomatica { get; set; }
        public string Combustivel { get; set; }
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
    }
    
}