using System;
using System.Collections.Generic;
using System.Text;

namespace SponsorLoeb.Data.Entities
{
    /// <summary>
    /// Mange-tilmange relation mellem Deltager og Sponsorbetaling.
    /// 
    /// I de fleste (private) tilfælde er der kun en betaling pr. deltager.
    /// Der kan dog være firmasponsorer, hvor en betaling dækker f.eks. alle deltagere i en skoleklasse
    /// </summary>
    public class Deltager_SponsorBetaling
    {
        public Deltager Deltager { get; set; }
        public SponsorBetaling SponsorBetaling { get; set; }

        //Foreign keys
        public int Deltager_Id { get; set; }

        public int Sponsorbetaling_Id { get; set; }

    }
}
