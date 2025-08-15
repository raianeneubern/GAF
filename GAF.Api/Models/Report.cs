using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.SignalR;

namespace GAF.Api.Models;

[Table("reports")]
public class Report
{
    [Key]
    public int Id {get; set;}

    [Required]
    public int Month { get; set; }

    [Required ]
    public int Year { get; set; }

    [Required ]
    [Column(TypeName = "decimal(18,2)")]
    public int Totalncome { get; set; }

    [Required ]
    [Column(TypeName = "decimal(18,2)")]
    public int TotalExpenses { get; set; }

    
    [Column(TypeName = "decimal(18,2)")]
    public decimal Balance => Totalncome - TotalExpenses;

    [Required]
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public virtual User User { get; set; }

    public DateTime GeneratedAt { get; set;} = DateTime.Now;


}