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

        //Foreign keys
        public int Sponsor_Id { get; set; }

    }
}
