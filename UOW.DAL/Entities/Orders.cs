using System.ComponentModel.DataAnnotations;

namespace UOW.DAL.Entities;

public class Orders : BaseEntity
{
    public string Number { get; set; } = null!;
    public Guid BookId { get; set; }
    public virtual Book? Books { get; set; }
}