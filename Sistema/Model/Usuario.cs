namespace Sistema.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Venda = new HashSet<Venda>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(15)]
        public string cpf { get; set; }

        [StringLength(15)]
        public string cnpj { get; set; }

        [StringLength(100)]
        public string rua { get; set; }

        [StringLength(100)]
        public string bairro { get; set; }

        [StringLength(100)]
        public string cidade { get; set; }

        [StringLength(100)]
        public string estado { get; set; }

        [StringLength(10)]
        public string cep { get; set; }

        public int is_fisica { get; set; }

        public int is_juridica { get; set; }

        public int is_cliente { get; set; }

        public int is_fornecedor { get; set; }

        public int is_funcionario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
