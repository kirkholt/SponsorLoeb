using System.Collections.Generic;

namespace SponsorLoeb.Data.Entities
{
    public class PostBy
    {
        #region Public Properties
        public int Id { get; set; }
        public string PostNr { get; set; }
        public string Bynavn { get; set; }
        #endregion

        #region Navigation Properties
        public ICollection<Bruger> Brugers { get; set; }
        public ICollection<Sponsor> Sponsors{ get; set; }
        #endregion
    }
}
