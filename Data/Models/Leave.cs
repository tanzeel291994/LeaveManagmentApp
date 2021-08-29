using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeaveManagmentApp.Models
{
    public class Leave
    {
        [Key]
        public int LeaveId { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string email { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ToDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Reason { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Details { get; set; }
    }
}
