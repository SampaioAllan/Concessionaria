using Microsoft.AspNetCore.Mvc;
using Concessionaria.Lib.Models;
using Concessionaria.Web.DTOs;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        public static List<CarroDTO> CarrosDaClasse { get; set; } = new List<CarroDTO>();

        [HttpGet("Get CarrosDaLista")]
        public IActionResult GetCarrosDaLista()
        {
            return Ok(CarrosDaClasse);
        }

        [HttpPost("Set CarroNaLista")]
        public IActionResult SetCarroNaLista(CarroDTO carroDTO)
        {
            try
            {
                var carro = new Carro(carroDTO.Marca,carroDTO.Modelo,carroDTO.Ano.ToString(),carroDTO.Quilometragem,carroDTO.Cor,carroDTO.Valor, carroDTO.TransmissaoAutomatica, carroDTO.Combustivel);
                CarrosDaClasse.Add(carroDTO);
                return Ok(CarrosDaClasse);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete CarroDaLista")]
        public IActionResult DeleteCarroDaLista()
        {
            CarrosDaClasse.RemoveAt(CarrosDaClasse.Count - 1);
            return Ok(CarrosDaClasse);
        }

    }
}