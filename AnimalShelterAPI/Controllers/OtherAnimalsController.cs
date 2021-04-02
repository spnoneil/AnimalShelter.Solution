using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System.Linq;
using System;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class OtherAnimalController : ControllerBase
  {
    private readonly AnimalShelterContext _db;
    public OtherAnimalController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<OtherAnimal>>> Get()
    {
      return await _db.OtherAnimals.ToListAsync();
    }
    [HttpPost]
    public async Task<ActionResult<OtherAnimal>> Post(OtherAnimal other)
    {
      other.DateAdded = DateTime.Now;
      _db.OtherAnimals.Add(other);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = other.OtherAnimalId }, other);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<OtherAnimal>> GetOtherAnimal(int id)
    {
      var other = await _db.OtherAnimals.FindAsync(id);
      if (other== null)
      {
        return NotFound();
      }
      return other;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, OtherAnimal other)
    {
      if (id != other.OtherAnimalId)
      {
        return BadRequest();
      }
      _db.Entry(other).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!OtherExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteOther(int id)
    {
      var other = await _db.OtherAnimals.FindAsync(id);
      if (other == null)
      {
        return NotFound();
      }
      _db.OtherAnimals.Remove(other);
      await _db.SaveChangesAsync();
      return NoContent();
    }

    private bool OtherExists(int id)
    {
      return _db.OtherAnimals.Any(e => e.OtherAnimalId == id);
    }
  }
}