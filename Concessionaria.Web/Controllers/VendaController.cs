using Microsoft.AspNetCore.Mvc;
using Concessionaria.Lib.Models;
using Concessionaria.Web.DTOs;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        public static List<VendaDTO> VendasDaClasse { get; set; } = new List<VendaDTO>();

        [HttpGet("Get VendasDaLista")]
        public IActionResult GetVendasDaLista()
        {
            return Ok(VendasDaClasse);
        }

        [HttpPost("Set VendaNaLista")]
        public IActionResult SetVendaNaLista(VendaDTO vendaDTO)
        {
            var compradorTeste = new Cliente(vendaDTO.CompradorDTO.Nome, vendaDTO.CompradorDTO.CPF, vendaDTO.CompradorDTO.DataNasc.ToString(), vendaDTO.CompradorDTO.Email, vendaDTO.CompradorDTO.Telefone);
            var vendedorTeste = new Funcionario(vendaDTO.VendedorDTO.Nome, vendaDTO.VendedorDTO.CPF, vendaDTO.VendedorDTO.DataNasc.ToString(), vendaDTO.VendedorDTO.Cargo);
            var veiculoTeste = new Veiculo(vendaDTO.VeiculoDTO.Marca, vendaDTO.VeiculoDTO.Modelo, vendaDTO.VeiculoDTO.Ano.ToString(), vendaDTO.VeiculoDTO.Quilometragem, vendaDTO.VeiculoDTO.Cor, vendaDTO.VeiculoDTO.Valor);
            var venda = new Venda(compradorTeste, vendedorTeste, veiculoTeste, vendaDTO.FormaDePagamento);
            VendasDaClasse.Add(vendaDTO);
            return Ok(VendasDaClasse);
        }

        [HttpDelete("Delete VendaDaLista")]
        public IActionResult DeleteVendaDaLista()
        {
            VendasDaClasse.RemoveAt(VendasDaClasse.Count - 1);
            return Ok(VendasDaClasse);
        }
    }
}