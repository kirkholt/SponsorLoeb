using System;
using System.Collections.Generic;

namespace SponsorLoeb.Data.Entities
{
    public class Deltager
    {
        public int Id { get; set; }
        public Bruger Bruger{ get; set; }
        public Hold? Hold { get; set; }
        //public DeltagerNr DeltagerNr { get; set; }
        public int? AntalOmgange { get; set; }

        public string Navn { get; set; }

        // Navigation properties
        public ICollection<Deltager_SponsorBetaling> Deltager_SponsorBetalinger { get; set; }

        // Foreign Keys
        public Guid Bruger_Id { get; set; }
        public int Hold_Id { get; set; }
        //public int DeltagerNr_Id { get; set; }
    }
}
