namespace AutoCare.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientBill")]
    public partial class ClientBill
    {
        [Key]
        public int billID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? billDate { get; set; }

        public string billNotes { get; set; }

        public int? billKilometerCount { get; set; }

        public double? billTotablPriceBefore { get; set; }

        public double? billTotablPriceAfter { get; set; }

        public double? billDiscount { get; set; }

        public double? billCash { get; set; }

        public double? billWorkerHandPrice { get; set; }

        public int? clientID { get; set; }

        public virtual Client Client { get; set; }
    }
}
