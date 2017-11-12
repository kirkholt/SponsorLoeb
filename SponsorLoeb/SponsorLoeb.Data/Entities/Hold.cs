using System.Collections.Generic;

namespace SponsorLoeb.Data.Entities
{
    public class Hold
    {
        public int Id { get; set; }
        public Loeb Loeb { get; set; }
        public string Navn { get; set; }
        public int? AntalElever { get; set; }

        public ICollection<Deltager> Deltagers { get; set; }
        // Foreign Keys
        public int Loeb_Id { get; set; }
    }
}
