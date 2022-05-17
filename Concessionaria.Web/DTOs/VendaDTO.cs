namespace Concessionaria.Web.DTOs
{
    public class VendaDTO
    {
        public ClienteDTO CompradorDTO { get; set; }
        public FuncionarioDTO VendedorDTO { get; set; }
        public VeiculoDTO VeiculoDTO { get; set; }
        public string FormaDePagamento { get; set; }
        public double ValorFinal { get; set; }
    }
}