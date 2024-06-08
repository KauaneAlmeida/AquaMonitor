using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aqua_monitor.Models;

[Table("PolutionTypes")]
public class PolutionTypes
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Type { get; set; } = string.Empty;
}