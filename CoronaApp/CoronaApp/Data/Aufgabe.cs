using CoronaApp.Data.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoronaApp.Data
{
    public class Aufgabe
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "GIEF TEXT YOU DUMB DOGHNUT")]
        [MinLength(5, ErrorMessage = "Min 5 zeichen")]
        [MaxLength(20, ErrorMessage = "Max 20 zeichen")]
        public string Text { get; set; }
        [DateInFuture(ErrorMessage = "Datum must im die Zukunft sein")]
        public DateTime ErledigtBis { get; set; }
        public bool Erledigt { get; set; }
        [JsonIgnore]
        [NotMapped]
        public bool Bearbeiten { get; set; }
    }
}
