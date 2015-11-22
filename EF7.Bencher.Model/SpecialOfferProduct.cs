using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class SpecialOfferProduct
    {
        public SpecialOfferProduct()
        {
            SalesOrderDetail = new HashSet<SalesOrderDetail>();
        }

        public int SpecialOfferID { get; set; }
        public int ProductID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid rowguid { get; set; }

        public virtual ICollection<SalesOrderDetail> SalesOrderDetail { get; set; }
        public virtual Product Product { get; set; }
        public virtual SpecialOffer SpecialOffer { get; set; }
    }
}
