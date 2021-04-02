using Microsoft.EntityFrameworkCore;
using System;

namespace AnimalShelter.Models
{
  public class OtherAnimal
  {
    public int OtherAnimalId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    
    public DateTime DateAdded { get; set; }
  }
}