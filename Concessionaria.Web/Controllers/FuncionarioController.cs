using Microsoft.AspNetCore.Mvc;
using Concessionaria.Lib.Models; 
using Concessionaria.Web.DTOs;

namespace ProjetoConcessionaria.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        public static List<FuncionarioDTO> FuncionariosDaClasse { get; set; } = new List<FuncionarioDTO>();

        [HttpGet("Get FuncionariosDaLista")]
        public IActionResult GetFuncionariosDaLista()
        {
            return Ok(FuncionariosDaClasse);
        }

        [HttpPost("Set FuncionarioNaLista")]
        public IActionResult SetFuncionarioNaLista(FuncionarioDTO funcionarioDTO)
        {
            var funcionario = new Funcionario(funcionarioDTO.Nome, funcionarioDTO.CPF, funcionarioDTO.DataNasc.ToString(), funcionarioDTO.Cargo);
            FuncionariosDaClasse.Add(funcionarioDTO);
            return Ok(FuncionariosDaClasse);
        }

        [HttpDelete("Delete FuncionarioDaLista")]
        public IActionResult DeleteFuncionarioDaLista()
        {
            FuncionariosDaClasse.RemoveAt(FuncionariosDaClasse.Count - 1);
            return Ok(FuncionariosDaClasse);
        }
    }
}