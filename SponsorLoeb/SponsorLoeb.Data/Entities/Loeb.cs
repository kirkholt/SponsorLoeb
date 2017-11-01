using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SponsorLoeb.Data.Entities
{
    public class Loeb: IValidatableObject
    {
        public int Id { get; set; }

        [Required]
        public string Navn { get; set; }
        public decimal LaendgePrOmgang { get; set; }
        public bool OmgangeTaelles { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.OmgangeTaelles)
            {
                if (this.LaendgePrOmgang <= 0.0m)
                {
                    yield return new ValidationResult("Laengde pr omgang skal angives", new[] { "LaendgePrOmgang" });
                }
            }
        }
    }
}
