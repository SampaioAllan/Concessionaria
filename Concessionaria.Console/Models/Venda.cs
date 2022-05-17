namespace Concessionaria
{
    public class Venda
    {
        private Cliente Comprador { get; set; }
        private Funcionario Vendedor { get; set; }
        private Veiculo Veiculo { get; set; }
        private string FormaDePagamento { get; set; }
        private double ValorFinal { get; set; }  
        public Venda(Cliente comprador, Funcionario vendedor, Veiculo veiculo, string formaDePagamento)
        {
            SetComprador(comprador);
            SetVendedor(vendedor);
            SetVeiculo(veiculo);
            SetFormaDePagamento(formaDePagamento);
            SetValorFinal(AplicarDesconto());
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
        public string GetFormaDePagamento()
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
        public double AplicarDesconto()
        {
            double valorVeiculo = Veiculo.GetValor();
            string cargoGerente = "gerente";
            if(Vendedor.GetCargo().Contains(cargoGerente))
            {
                valorVeiculo = valorVeiculo * 0.95;
            }
            return valorVeiculo;
        }

    }
}