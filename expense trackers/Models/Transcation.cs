using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace expense_trackers.Models
{
    public class Transcation
    {
        //this is kaviyarasu model.
        [Key]
        public int TransactionId { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Amonut { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } =DateTime.Now;
    }
}
