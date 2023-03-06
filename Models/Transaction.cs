using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace budget_monitor_app.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; } 

        // CategoryID
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }
         
        public string Type { get; set; } 





    }
}
