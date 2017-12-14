using MyFoodServer.API.Context;
using MyFoodServer.Dal.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace MyFoodServer.API.Controllers
{
    public class RestaurantesController : ApiController
    {
        private MyFoodContext db = new MyFoodContext();

        // GET: api/Restaurantes
        [Route("api/restaurantes"), HttpGet]
        public IQueryable<Restaurante> GetRestaurantes()
        {
            return db.Restaurantes;
        }

        // GET: api/Restaurantes/5
        [Route("api/restaurantes/{id}"), HttpGet]
        [ResponseType(typeof(Restaurante))]
        public IHttpActionResult GetRestaurante(int id)
        {
            Restaurante restaurante = db.Restaurantes.Find(id);
            if (restaurante == null)
            {
                return NotFound();
            }

            return Ok(restaurante);
        }

        // GET: api/Restaurantes/5/comidas
        [Route("api/restaurantes/{id}/comidas"), HttpGet]
        public IQueryable<Comida> GetComidasRestaurante(int id)
        {
            return from c in db.Comidas
                   join r in db.Restaurantes on c.Restaurante.Id equals r.Id
                   where r.Id == id
                   select c;
        }

        // PUT: api/Restaurantes/5
        [Route("api/restaurantes/{id}"), HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRestaurante(int id, Restaurante restaurante)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != restaurante.Id)
            {
                return BadRequest();
            }

            db.Entry(restaurante).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestauranteExists(id))
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

        // POST: api/Restaurantes
        [Route("api/restaurantes"), HttpPost]
        [ResponseType(typeof(Restaurante))]
        public IHttpActionResult PostRestaurante(Restaurante restaurante)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Restaurantes.Add(restaurante);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = restaurante.Id }, restaurante);
        }

        // DELETE: api/Restaurantes/5
        [Route("api/restaurantes/{id}"), HttpDelete]
        [ResponseType(typeof(Restaurante))]
        public IHttpActionResult DeleteRestaurante(int id)
        {
            Restaurante restaurante = db.Restaurantes.Find(id);
            if (restaurante == null)
            {
                return NotFound();
            }

            db.Restaurantes.Remove(restaurante);
            db.SaveChanges();

            return Ok(restaurante);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RestauranteExists(int id)
        {
            return db.Restaurantes.Count(e => e.Id == id) > 0;
        }
    }
}