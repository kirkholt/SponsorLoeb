using System;
using System.Collections.Generic;

namespace SponsorLoeb.Data.Entities
{
    public class Bruger
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public PostBy PostBy { get; set; }
        public string Telefon { get; set; }

        // Navigation Properties
        public ICollection<Sponsor> Sponsorer{ get; set; }
        public ICollection<Deltager> Deltagere { get; set; }

        // Foreign Keys
        public int PostBy_Id { get; set; }
    }
}
