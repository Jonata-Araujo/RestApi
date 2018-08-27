using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestAPI01.Data;
using RestAPI01.Models;

namespace RestAPI01.Controllers
{
    [Route("api/[controller]")]
    public class PratoController : Controller
    {

        protected Contexto contexto;

        public PratoController()
        {
            contexto = new Contexto();
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Json(contexto.pratos);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(contexto.pratos.SingleOrDefault(r => r.id == id));
        }

        // PUT api/values - CREATE
        [HttpPut]
        public IActionResult Put([FromBody] Prato value)
        {
            contexto.pratos.Add(value);
            contexto.SaveChanges();
            return NoContent();
        }

        // POST api/values - UPDATE
        [HttpPost("{id}")]
        public IActionResult Post(int id, [FromBody] Prato value)
        {
            if (id == value.id)
            {
                Prato prato = contexto.pratos.SingleOrDefault(r => r.id == id);
                if (prato != null)
                {
                    prato.nome = value.nome;
                    prato.idrestaurante = value.idrestaurante;
                }
                else
                {
                    return NotFound();
                }
                contexto.pratos.Update(prato);
                contexto.SaveChanges();
            }
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Prato prato = contexto.pratos.Find(id);
            if (prato == null)
            {
                return NotFound();
            }
            contexto.pratos.Remove(prato);
            contexto.SaveChanges();
            return NoContent();
        }
    }
}
