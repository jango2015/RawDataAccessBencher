using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class SpecialOffer
    {
        public SpecialOffer()
        {
            SpecialOfferProduct = new HashSet<SpecialOfferProduct>();
        }

        public int SpecialOfferID { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal DiscountPct { get; set; }
        public DateTime EndDate { get; set; }
        public int? MaxQty { get; set; }
        public int MinQty { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid rowguid { get; set; }
        public DateTime StartDate { get; set; }
        public string Type { get; set; }

        public virtual ICollection<SpecialOfferProduct> SpecialOfferProduct { get; set; }
    }
}
