using Concessionaria.MinhasExceptions;
namespace Concessionaria
{
    public class Veiculo
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private DateTime Ano { get; set; }
        private int Quilometragem { get; set; }
        private string Cor { get; set; }
        protected double Valor { get; set; }
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
            ValidarAno(DateTime.Parse(ano));
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
            ValidarValor(valor);
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

        public bool ValidarAno(DateTime ano)
        {
            if (ano.Year > 2003 && ano.Year <= DateTime.Today.Year)
            {
                return true;
            }
            throw new ValidacaoDeDados("Ano inválido!");
        }
        public virtual bool ValidarValor(double valor)
        {
            if (valor >= 0)
            {
                return true;
            }
            throw new ValidacaoDeDados("Valor inválido!");
        }
    }
}