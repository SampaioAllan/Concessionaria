using Microsoft.AspNetCore.Mvc;
using Concessionaria.Lib.Models;
using Concessionaria.Web.DTOs;
namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        public static List<ClienteDTO> ClientesDaClasse { get; set; } = new List<ClienteDTO>();

        [HttpGet("Get ClientesDaLista")]
        public IActionResult GetClientesDaLista()
        {
            return Ok(ClientesDaClasse);
        }

        [HttpPost("Set ClienteNaLista")]
        public IActionResult SetClienteNaLista(ClienteDTO clienteDTO)
        {
            try
            {
                var cliente = new Cliente(clienteDTO.Nome, clienteDTO.CPF, clienteDTO.DataNasc.ToString(), clienteDTO.Email, clienteDTO.Telefone);                ClientesDaClasse.Add(clienteDTO);
                return Ok(ClientesDaClasse);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete ClienteDaLista")]
        public IActionResult DeleteClienteDaLista()
        {
            ClientesDaClasse.RemoveAt(ClientesDaClasse.Count - 1);
            return Ok(ClientesDaClasse);
        }
    }
}