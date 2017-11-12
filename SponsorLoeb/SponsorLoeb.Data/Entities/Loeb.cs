using System.Collections.Generic;

namespace SponsorLoeb.Data.Entities
{
    public class Loeb
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public decimal LaendgePrOmgang { get; set; }
        public bool OmgangeTaelles { get; set; }

        public virtual ICollection<Hold> Holds{ get; set; }
        public virtual ICollection<DeltagerNr> DeltagerNrs { get; set; }
    }
}
