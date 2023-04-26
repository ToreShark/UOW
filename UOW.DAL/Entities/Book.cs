using System.ComponentModel.DataAnnotations;

namespace UOW.DAL.Entities;

public class Book
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
}