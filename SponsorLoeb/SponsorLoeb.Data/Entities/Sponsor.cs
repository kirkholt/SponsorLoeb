using System.Collections.Generic;
using SponsorLoeb.Data.Enums;

namespace SponsorLoeb.Data.Entities
{
    public class Sponsor
    {
        public int Id { get; set; }
        public  SponsorType SponsorType { get; set; }
        public PostBy PostBy { get; set; }
        public Bruger Bruger { get; set; }
        public string Navn { get; set; }
        public string Att { get; set; }
        public string Adresse { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public ICollection<SponsorBetaling> SponsorBetalings{ get; set; }

        // Foreign Keys
        public int? PostBy_Id { get; set; }
        public int Bruger_Id { get; set; }

    }
}
