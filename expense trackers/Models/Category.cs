using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace expense_trackers.Models
{
    public class Category
    {
        //hi frnds new to learn this course
        [Key]
        public int categoryId { get;set; }

        [Column(TypeName ="nvarchar(50)")]
        public string Title { get;set; }

        [Column(TypeName = "nvarchar(50)")]
        public string icon { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string type { get; set; } = "Expense";
    }
}
