using System;
using System.Collections.Generic;
using System.Text;

namespace SponsorLoeb.Data.Entities
{
    public class Loeb
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public decimal LaendgePrOmgang { get; set; }
        public bool OmgangeTaelles { get; set; }
    }
}
