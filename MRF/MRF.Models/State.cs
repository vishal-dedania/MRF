using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRF.Models
{
    public class State
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string StateName { get; set; }

        [Required]
        public string StateId { get; set; }
    }
}