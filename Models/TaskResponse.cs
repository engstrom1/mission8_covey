using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace mission8_covey.Models
{
    public class TaskResponse
    {
        [Key]
        [Required]
        public int TaskId { get; set; }
        [Required]
        public string Task { get; set; }

        public DateTime dueDate { get; set; }

        [Required]
        public int quadrant { get; set; }

        [Required]
        public bool completed { get; set; }

        [Required] // foreign keys
        public int CategoryID { get; set; }

        public Category Category { get; set; }

        

    }
}
