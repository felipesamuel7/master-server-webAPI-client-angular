using MyFoodServer.API.Context;
using MyFoodServer.Dal.Models;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace MyFoodServer.API.Controllers
{
    public class ComidasController : ApiController
    {
        private MyFoodContext db = new MyFoodContext();

        // GET: api/Comidas
        [Route("api/comidas"), HttpGet]
        public IQueryable<ComidaRestaurante> GetComidas()
        {
            return from c in db.Comidas
                   join r in db.Restaurantes on c.Restaurante.Id equals r.Id
                   select new ComidaRestaurante
                   {
                       IdComida = c.Id,
                       NomeComida = c.Nome,
                       Descricao = c.Descricao,
                       Valor = c.Valor,
                       IdRestaurante = r.Id,
                       NomeRestaurante = r.Nome,
                       Logradouro = r.Logradouro,
                       Complemento = r.Complemento,
                       Numero = r.Numero,
                       Bairro = r.Bairro,
                       Cidade = r.Cidade,
                       Estado = r.Estado,
                       Telefone = r.Telefone
                   };
        }

        // GET: api/Comidas/5
        [Route("api/comidas/{id}"), HttpGet]
        [ResponseType(typeof(ComidaRestaurante))]
        public IHttpActionResult GetComida(int id)
        {
            ComidaRestaurante comida = (from c in db.Comidas
                                    join r in db.Restaurantes on c.Restaurante.Id equals r.Id
                                    where c.Id == id
                                    select new ComidaRestaurante
                                    {
                                        IdComida = c.Id,
                                        NomeComida = c.Nome,
                                        Descricao = c.Descricao,
                                        Valor = c.Valor,
                                        IdRestaurante = r.Id,
                                        NomeRestaurante = r.Nome,
                                        Logradouro = r.Logradouro,
                                        Complemento = r.Complemento,
                                        Numero = r.Numero,
                                        Bairro = r.Bairro,
                                        Cidade = r.Cidade,
                                        Estado = r.Estado,
                                        Telefone = r.Telefone
                                    }).FirstOrDefault();
            if (comida == null)
            {
                return NotFound();
            }

            return Ok(comida);
        }

        // PUT: api/Comidas/5
        [Route("api/comidas/{id}"), HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutComida(int id, Comida comida)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != comida.Id)
            {
                return BadRequest();
            }

            db.Entry(comida).State = System.Data.Entity.EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComidaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Comidas
        [Route("api/comidas"), HttpPost]
        [ResponseType(typeof(Comida))]
        public IHttpActionResult PostComida(Comida comida)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Comidas.Add(comida);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = comida.Id }, comida);
        }

        // DELETE: api/Comidas/5
        [Route("api/comidas/{id}"), HttpDelete]
        [ResponseType(typeof(Comida))]
        public IHttpActionResult DeleteComida(int id)
        {
            Comida comida = db.Comidas.Find(id);
            if (comida == null)
            {
                return NotFound();
            }

            db.Comidas.Remove(comida);
            db.SaveChanges();

            return Ok(comida);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ComidaExists(int id)
        {
            return db.Comidas.Count(e => e.Id == id) > 0;
        }
    }
}