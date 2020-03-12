using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaApp.Data
{
    public class BMIData
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Height { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Weight { get; set; }
    }
}
