using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aqua_monitor.Models;

[Table("OceanWaterData")]
public class OceanWaterData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public double Salinity { get; set; }

    public double Ph { get; set; }

    public double Temperature { get; set; }

    public double PolutionTypeFk { get; set; }

    public double WaterLvl { get; set; }
}