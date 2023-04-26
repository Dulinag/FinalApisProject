using System.Collections.Generic;
using System.Linq;
using FFFP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFFP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly MyFirstAPIDBContext _context;

        public PatientController(MyFirstAPIDBContext context)
        {
            _context = context;
        }

        // GET /patient
        [HttpGet]
        public ActionResult<List<Patients>> GetAll()
        {
            // Retrieve all patients from the database and return as a list
            return _context.Patients.ToList();
        }

        // GET /patient/{id}
        [HttpGet("{id}")]
        public ActionResult<Patients> GetById(int id)
        {
            // Find the patient with the specified id in the database
            var patient = _context.Patients.Find(id);

            // Return 404 Not Found if patient is not found
            if (patient == null)
            {
                return NotFound();
            }

            // Return the patient with the specified id
            return patient;
        }

        // POST /patient
        [HttpPost]
        public IActionResult Create(Patients patient)
        {
            // Add the new patient to the database
            _context.Patients.Add(patient);

            // Save changes to the database
            _context.SaveChanges();

            // Return a 201 Created response with the newly created patient object
            return CreatedAtAction(nameof(GetById), new { id = patient.PatientId }, patient);
        }

        // PUT /patient/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, Patients patient)
        {
            // Return a 400 Bad Request response if the id in the URL does not match the id in the patient object
            if (id != patient.PatientId)
            {
                return BadRequest();
            }

            // Mark the patient object as modified and save changes to the database
            _context.Entry(patient).State = EntityState.Modified;
            _context.SaveChanges();

            // Return a 204 No Content response to indicate success
            return NoContent();
        }

        // DELETE /patient/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Find the patient with the specified id in the database
            var patient = _context.Patients.Find(id);

            // Return 404 Not Found if patient is not found
            if (patient == null)
            {
                return NotFound();
            }

            // Remove the patient from the database and save changes
            _context.Patients.Remove(patient);
            _context.SaveChanges();

            // Return a 204 No Content response to indicate success
            return NoContent();
        }
    }
}
