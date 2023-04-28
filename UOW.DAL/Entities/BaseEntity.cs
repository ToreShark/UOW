using System.ComponentModel.DataAnnotations;

namespace UOW.DAL.Entities;

public abstract class BaseEntity
{
    [Key] 
    public Guid Id { get; set; }
}