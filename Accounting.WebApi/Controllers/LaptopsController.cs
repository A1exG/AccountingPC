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
using Accounting.Model.EntityLibrary.Entityes.Computers;
using Accounting.WebApi.MyDbContext;

namespace Accounting.WebApi.Controllers
{
    public class LaptopsController : ApiController
    {
        private AccountingDbContext db = new AccountingDbContext();

        // GET: api/Laptops
        public IQueryable<Laptop> GetLaptops()
        {
            return db.Laptops;
        }

        // GET: api/Laptops/5
        [ResponseType(typeof(Laptop))]
        public IHttpActionResult GetLaptop(int id)
        {
            Laptop laptop = db.Laptops.Find(id);
            if (laptop == null)
            {
                return NotFound();
            }

            return Ok(laptop);
        }

        // PUT: api/Laptops/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLaptop(int id, Laptop laptop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != laptop.Id)
            {
                return BadRequest();
            }

            db.Entry(laptop).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LaptopExists(id))
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

        // POST: api/Laptops
        [ResponseType(typeof(Laptop))]
        public IHttpActionResult PostLaptop(Laptop laptop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Laptops.Add(laptop);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = laptop.Id }, laptop);
        }

        // DELETE: api/Laptops/5
        [ResponseType(typeof(Laptop))]
        public IHttpActionResult DeleteLaptop(int id)
        {
            Laptop laptop = db.Laptops.Find(id);
            if (laptop == null)
            {
                return NotFound();
            }

            db.Laptops.Remove(laptop);
            db.SaveChanges();

            return Ok(laptop);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LaptopExists(int id)
        {
            return db.Laptops.Count(e => e.Id == id) > 0;
        }
    }
}