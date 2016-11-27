namespace Sistema.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Venda")]
    public partial class Venda
    {
        public int id { get; set; }

        public int? quantidade { get; set; }

        public decimal? valor { get; set; }

        public int id_usuario { get; set; }

        [StringLength(10)]
        public string pagamento { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
