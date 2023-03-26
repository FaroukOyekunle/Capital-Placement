using System.ComponentModel.DataAnnotations;
namespace ConsoleProject.Models;

public abstract class BaseModel
{
    [Key]
    public string Id { get; private set; } = Guid.NewGuid().ToString();
}
public abstract class ProfileBase
{

    public bool Mandatory { get; set; }
    public bool Hidden { get; set; }
}
