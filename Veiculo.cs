namespace Concessionaria
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public int Quilometragem { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }
        public Veiculo (string marca, string modelo, string ano, int quilometragem, string cor, double valor)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetAno(ano);
            SetQuilometragem(quilometragem);
            SetCor(cor);
            SetValor(valor);
        }
        public void SetMarca(string marca)
        {
            Marca=marca;
        }
        public string GetMarca()
        {
            return Marca;
        }
        public void SetModelo(string modelo)
        {
            Modelo=modelo;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public void SetAno(string ano)
        {
            Ano=DateTime.Parse(ano);
        }
        public DateTime GetAno()
        {
            return Ano;
        }
        public void SetQuilometragem(int km)
        {
            Quilometragem=km;
        }
        public int GetQuilometragem()
        {
            return Quilometragem;
        }
        public void SetCor(string cor)
        {
            Cor=cor;
        }
        public string GetCor()
        {
            return Cor;
        }
        public void SetValor(double valor)
        {
            Valor=valor;
        }
        public double GetValor()
        {
            return Valor;
        }

        public virtual double CalcValor()
        {
            return Valor;
        }
    }
}