namespace Concessionaria
{
    public class Venda
    {
        public Cliente Comprador { get; set; }
        public Funcionario Vendedor { get; set; }
        public Veiculo Veiculo { get; set; }
        public string FormaDePagamento { get; set; }
        public double ValorFinal { get; set; }  
        public Venda(Cliente comprador, Funcionario vendedor, Veiculo veiculo, string formaDePagamento, double valorFinal)
        {
            SetComprador(comprador);
            SetVendedor(vendedor);
            SetVeiculo(veiculo);
            SetFormaDePagamento(formaDePagamento);
            SetValorFinal(valorFinal);
        }
        public void SetComprador(Cliente comprador)
        {
            Comprador=comprador;
        }
        public Cliente GetComprador()
        {
            return Comprador;
        }
        public void SetVendedor(Funcionario vendedor)
        {
            Vendedor=vendedor;
        }

        public Funcionario GetVendedor()
        {
            return Vendedor;
        }  
        public void SetVeiculo(Veiculo veiculo)
        {
            Veiculo=veiculo;
        }
        public Veiculo GetVeiculo()
        {
            return Veiculo;
        }
        public void SetFormaDePagamento(string formaDePagamento)
        {
            FormaDePagamento=formaDePagamento;
        }
        public string GetFomaDePagamento()
        {
            return FormaDePagamento;
        }
        public void SetValorFinal(double valorFinal)
        {
            ValorFinal=valorFinal;
        }
        public double GetValorFinal()
        {
            return ValorFinal;
        }

    }
}