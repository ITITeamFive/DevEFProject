namespace AutoCare.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierBill")]
    public partial class SupplierBill
    {
        [Key]
        public int billID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? billDate { get; set; }

        public string billNotes { get; set; }

        public double? billTotablPriceBefore { get; set; }

        public double? billTotablPriceAfter { get; set; }

        public double? billDiscount { get; set; }

        public double? billCash { get; set; }

        public int? supplierID { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
