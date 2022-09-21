using Microsoft.AspNetCore.Mvc;
using TrilhaApiDesafio.Context;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<Tarefa> ObterPorId(int id)
        {
            Tarefa tarefa = _context.Tarefas.Find(id);
            if (tarefa is null)
            {
                return NotFound();
            }
            return Ok(tarefa);
        }

        [HttpGet("ObterTodos")]
        public ActionResult<List<Tarefa>> ObterTodos()
        {
            List<Tarefa> tarefas = _context.Tarefas.ToList();
            return Ok(tarefas);
        }

        [HttpGet("ObterPorTitulo")]
        public ActionResult<Tarefa> ObterPorTitulo(string titulo)
        {
            Tarefa tarefa = _context.Tarefas.Where(x => x.Titulo.Equals(titulo)).FirstOrDefault();
            if (tarefa is null)
            {
                return NotFound();
            }
            return Ok(tarefa);
        }

        [HttpGet("ObterPorData")]
        public ActionResult<List<Tarefa>> ObterPorData(DateTime data)
        {
            List<Tarefa> tarefas = _context.Tarefas.Where(x => x.Data.Date == data.Date).ToList();
            if (tarefas is null)
            {
                return NotFound();
            }
            return Ok(tarefas);
        }

        [HttpGet("ObterPorStatus")]
        public ActionResult<List<Tarefa>> ObterPorStatus(EnumStatusTarefa status)
        {
            List<Tarefa> tarefas = _context.Tarefas.Where(x => x.Status == status).ToList();
            if (tarefas is null)
            {
                return NotFound();
            }
            return Ok(tarefas);
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            if (tarefa.Data == DateTime.MinValue)
            {
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });
            }
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            Tarefa tarefaBanco = _context.Tarefas.Find(id);
            if (tarefaBanco == null)
            {
                return NotFound();
            }
            if (tarefa.Data == DateTime.MinValue)
            {
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });
            }
            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Status = tarefa.Status;

            _context.Tarefas.Update(tarefaBanco);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            Tarefa tarefaBanco = _context.Tarefas.Find(id);
            if (tarefaBanco == null)
            {
                return NotFound();
            }
            _context.Tarefas.Remove(tarefaBanco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
