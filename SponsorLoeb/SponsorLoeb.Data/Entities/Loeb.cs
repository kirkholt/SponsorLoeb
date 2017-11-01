using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SponsorLoeb.Data.Entities
{
    public class Loeb
    {
        public int Id { get; set; }

        [Required]
        public string Navn { get; set; }
        public decimal LaendgePrOmgang { get; set; }
        public bool OmgangeTaelles { get; set; }
    }
}
