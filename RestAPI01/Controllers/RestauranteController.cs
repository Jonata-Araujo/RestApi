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
    public class RestauranteController : Controller
    {

        protected Contexto contexto;

        public RestauranteController()
        {
            contexto = new Contexto();
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Json(contexto.restaurantes.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(contexto.restaurantes.SingleOrDefault(r => r.id == id));
        }

        // PUT api/values - CREATE
        [HttpPut]
        public IActionResult Put([FromBody] Restaurante value)
        {
            contexto.restaurantes.Add(value);
            contexto.SaveChanges();
            return NoContent();
        }

        // POST api/values - UPDATE
        [HttpPost("{id}")]
        public IActionResult Post(int id, [FromBody] Restaurante value)
        {
            if(id == value.id)
            {
                Restaurante restaurante = contexto.restaurantes.SingleOrDefault(r => r.id == id);
                if(restaurante != null)
                {
                    restaurante.nome = value.nome;
                }
                else
                {
                    return NotFound();
                }
                contexto.restaurantes.Update(restaurante);
                contexto.SaveChanges();
            }
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Restaurante restaurante = contexto.restaurantes.Find(id);
            if (restaurante == null)
            {
                return NotFound();
            }
            contexto.restaurantes.Remove(restaurante);
            contexto.SaveChanges();
            return NoContent();
        }
    }
}
