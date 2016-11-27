namespace Sistema.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB_Model : DbContext
    {
        public DB_Model()
            : base("name=DB_Model")
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Venda> Venda { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .Property(e => e.nome)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.cpf)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.cnpj)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.rua)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.bairro)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.cidade)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.estado)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .Property(e => e.cep)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Venda)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.id_usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Venda>()
                .Property(e => e.valor)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Venda>()
                .Property(e => e.pagamento)
                .IsFixedLength();
        }
    }
}
