using System.ComponentModel.DataAnnotations;

namespace UOW.DAL.Entities;

public class Book : BaseEntity
{
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
}