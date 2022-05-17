using Microsoft.AspNetCore.Mvc;
using Concessionaria;
using Concessionaria.Web.DTOs;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase
    {
        public static List<MotoDTO> MotosDaClasse { get; set; } = new List<MotoDTO>();

        [HttpGet("Get MotosDaLista")]
        public IActionResult GetMotosDaLista()
        {
            return Ok(MotosDaClasse);
        }

        [HttpPost("Set MotoNaLista")]
        public IActionResult SetMotoNaLista(MotoDTO motoDTO)
        {
            try
            {
                var moto = new Moto(motoDTO.Marca, motoDTO.Modelo, motoDTO.Ano.ToString(), motoDTO.Quilometragem, motoDTO.Cor, motoDTO.Valor, motoDTO.Cilindrada, motoDTO.Partida);
                MotosDaClasse.Add(motoDTO);
                return Ok(MotosDaClasse);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("Delete MotoDaLista")]
        public IActionResult DeleteMotoDaLista()
        {
            MotosDaClasse.RemoveAt(MotosDaClasse.Count - 1);
            return Ok(MotosDaClasse);
        }

    }
}