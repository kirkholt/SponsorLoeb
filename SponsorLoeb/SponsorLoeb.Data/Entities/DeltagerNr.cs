namespace SponsorLoeb.Data.Entities
{
    public class DeltagerNr
    {
        public int Id { get; set; }
        public Loeb Loeb { get; set; }
        public Deltager Deltager { get; set; }

        public bool Eksisterer { get; set; }

        // Foreign Keys
        public int Loeb_Id { get; set; }
        public int Deltager_Id { get; set; }
    }
}
