using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using APISession2Auth.Models;

namespace APISession2Auth.Controllers
{
    public class estadiosController : ApiController
    {
        private Session2WSTowersEntities db = new Session2WSTowersEntities();

        // GET: api/estadios
        [Authorize]
        public IHttpActionResult Getestadios()
        {
            return Ok(db.estadios.ToList().Select(x => new
            {
                x.capacidade,
                x.cod_est,
                x.nom_est,
                x.uf_estadio
            }).ToList());
        }

        // GET: api/estadios/5
        [ResponseType(typeof(estadios))]
        public IHttpActionResult Getestadios(int id)
        {
            estadios estadios = db.estadios.Find(id);
            if (estadios == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                estadios.capacidade,
                estadios.cod_est,
                estadios.nom_est,
                estadios.uf_estadio
            });
        }

        // PUT: api/estadios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putestadios(int id, estadios estadios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != estadios.cod_est)
            {
                return BadRequest();
            }

            db.Entry(estadios).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!estadiosExists(id))
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

        // POST: api/estadios
        [ResponseType(typeof(estadios))]
        public IHttpActionResult Postestadios(estadios estadios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            db.estadios.Add(estadios);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (estadiosExists(estadios.cod_est))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = estadios.cod_est }, estadios);
        }

        // DELETE: api/estadios/5
        [ResponseType(typeof(estadios))]
        public IHttpActionResult Deleteestadios(int id)
        {
            estadios estadios = db.estadios.Find(id);
            if (estadios == null)
            {
                return NotFound();
            }

            db.estadios.Remove(estadios);
            db.SaveChanges();

            return Ok(estadios);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool estadiosExists(int id)
        {
            return db.estadios.Count(e => e.cod_est == id) > 0;
        }
    }
}