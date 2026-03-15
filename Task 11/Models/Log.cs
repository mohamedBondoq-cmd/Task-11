using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Task_11.Models;

[Table("logs")]
public partial class Log
{
    [Key]
    [Column("log_id")]
    public int LogId { get; set; }

    [Column("massage")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Massage { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }
}
