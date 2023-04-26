using System.Collections.Generic;
using System.Linq;
using FFFP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFFP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly MyFirstAPIDBContext _context;

        // Constructor that injects the database context via dependency injection
        public DoctorController(MyFirstAPIDBContext context)
        {
            _context = context;
        }

        // GET /doctor - Returns a list of all doctors
        [HttpGet]
        public ActionResult<List<Doctors>> GetAll()
        {
            // Retrieve all doctors from the database and return as a list
            return _context.Doctors.ToList();
        }

        // GET /doctor/{id} - Returns the doctor with the specified ID
        [HttpGet("{id}")]
        public ActionResult<Doctors> GetById(int id)
        {
            // Attempt to retrieve the doctor with the specified ID from the database
            var doctor = _context.Doctors.Find(id);

            // If the doctor is not found, return a 404 Not Found response
            if (doctor == null)
            {
                return NotFound();
            }

            // Otherwise, return the doctor object
            return doctor;
        }

        // POST /doctor - Creates a new doctor
        [HttpPost]
        public IActionResult Create(Doctors doctor)
        {
            // Add the new doctor to the database and save changes
            _context.Doctors.Add(doctor);
            _context.SaveChanges();

            // Return a 201 Created response with the URI of the newly created doctor
            return CreatedAtAction(nameof(GetById), new { id = doctor.DoctorId }, doctor);
        }

        // PUT /doctor/{id} - Updates the doctor with the specified ID
        [HttpPut("{id}")]
        public IActionResult Update(int id, Doctors doctor)
        {
            // If the ID in the request URL does not match the ID in the request body, return a 400 Bad Request response
            if (id != doctor.DoctorId)
            {
                return BadRequest();
            }

            // Set the state of the doctor object to modified and save changes
            _context.Entry(doctor).State = EntityState.Modified;
            _context.SaveChanges();

            // Return a 204 No Content response
            return NoContent();
        }

        // DELETE /doctor/{id} - Deletes the doctor with the specified ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Attempt to retrieve the doctor with the specified ID from the database
            var doctor = _context.Doctors.Find(id);

            // If the doctor is not found, return a 404 Not Found response
            if (doctor == null)
            {
                return NotFound();
            }

            // Remove the doctor from the database and save changes
            _context.Doctors.Remove(doctor);
            _context.SaveChanges();

            // Return a 204 No Content response
            return NoContent();
        }
    }
}
