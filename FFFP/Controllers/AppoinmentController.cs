using FFFP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFFP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly MyFirstAPIDBContext _context;

        public AppointmentController(MyFirstAPIDBContext context)
        {
            _context = context;
        }

        // GET: api/Appointment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Appointments>>> GetAppointments()
        {
            // Retrieve all appointments from the database
            return await _context.Appointments.ToListAsync();
        }

        // GET: api/Appointment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Appointments>> GetAppointment(int id)
        {
            // Find the appointment with the specified ID
            var appointment = await _context.Appointments.FindAsync(id);

            // If no appointment is found, return a 404 error
            if (appointment == null)
            {
                return NotFound();
            }

            // Otherwise, return the appointment
            return appointment;
        }

        // POST: api/Appointment
        [HttpPost]
        public async Task<ActionResult<Appointments>> PostAppointment(Appointments appointment)
        {
            // Add the new appointment to the database
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();

            // Return a 201 status code to indicate success and include the new appointment in the response body
            return CreatedAtAction(nameof(GetAppointment), new { id = appointment.AppointmentId }, appointment);
        }

        // PUT: api/Appointment/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppointment(int id, Appointments appointment)
        {
            // If the appointment ID in the request body doesn't match the one in the URL, return a 400 error
            if (id != appointment.AppointmentId)
            {
                return BadRequest();
            }

            // Mark the appointment as modified in the database context
            _context.Entry(appointment).State = EntityState.Modified;

            try
            {
                // Save changes to the database
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // If the appointment is not found in the database, return a 404 error
                if (!AppointmentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            // Return a 204 status code to indicate success with no content
            return NoContent();
        }

        // DELETE: api/Appointment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            // Find the appointment with the specified ID
            var appointment = await _context.Appointments.FindAsync(id);

            // If no appointment is found, return a 404 error
            if (appointment == null)
            {
                return NotFound();
            }

            // Remove the appointment from the database
            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();

            // Return the deleted appointment
            return (IActionResult)appointment;
        }

        private bool AppointmentExists(int id)
        {
            // Check if an appointment with the specified ID exists in the database
            return _context.Appointments.Any(e => e.AppointmentId == id);
        }
    }
}
