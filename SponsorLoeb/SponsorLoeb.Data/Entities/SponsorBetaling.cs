using System.Collections.Generic;

namespace SponsorLoeb.Data.Entities
{
    public class SponsorBetaling
    {
        public int Id { get; set; }
        public Sponsor Sponsor { get; set; }
        public decimal? FastBeloebIalt { get; set; }
        public decimal? FastBeloebPrDeltager { get; set; }
        public decimal? FastBeloebPrKm { get; set; }
        public decimal? MaksBeloeb { get; set; }

        // Navigation properties
        public ICollection<Deltager_SponsorBetaling> Deltager_SponsorBetalinger  { get; set; }

        //Foreign keys
        public int Sponsor_Id { get; set; }

    }
}
