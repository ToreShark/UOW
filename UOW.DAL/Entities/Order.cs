using System.ComponentModel.DataAnnotations;

namespace UOW.DAL.Entities;

public class Order
{
    [Key]
    public Guid Id { get; set; }
    public string Number { get; set; } = null!;
    public Guid BookId { get; set; }
    public virtual Book? Book { get; set; }
}