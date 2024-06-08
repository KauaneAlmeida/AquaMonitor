using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aqua_monitor.Models;

[Table("MonitoringLocation")]
public class MonitoringLocation
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    // Foreign Key property
    public int OceanWaterDataId { get; set; } = 4;

    // Navigation property
    [ForeignKey("OceanWaterDataId")]
    public OceanWaterData OceanWaterData { get; set; }

    public double Latitude;
    
    public double Longitude;
}