using Microsoft.EntityFrameworkCore;
using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; private set; }
    public string Type { get; set; }
    public DateTime DateAdded { get; set; }
  }
}