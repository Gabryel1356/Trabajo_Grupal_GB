using Microsoft.AspNetCore.Mvc;
using MsPaciente.Api.Context;
using MsPaciente.Api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MsPaciente.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {

        private readonly AppDbContext context;

        public PacienteController(AppDbContext context)
        {
            this.context = context;
        }



        // GET: api/<PacienteController>
        [HttpGet]
        public IEnumerable<Paciente> Get()
        {
            return context.Pacientes.ToList();
        }

        // GET api/<PacienteController>/5
        [HttpGet("{id}")]
        public Paciente Get(int id)
        {
            var paciente = context.Pacientes.FirstOrDefault(p => p.idPac == id);
            return paciente;
        }


        // POST api/<PacienteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PacienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PacienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}






