using Microsoft.EntityFrameworkCore;
using System;

namespace AnimalShelter.Models
{
  public class Dog
  {
    public int DogId { get; private set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public DateTime DateAdded { get; set; }
  }
}