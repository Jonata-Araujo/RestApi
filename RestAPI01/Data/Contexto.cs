using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestAPI01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI01.Data
{
    public class Contexto:DbContext
    {
        public DbSet<Restaurante> restaurantes { get; set; }
        public DbSet<Prato> pratos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapRestaurante());
            modelBuilder.ApplyConfiguration(new MapPrato());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost; user id=root;password=root;persistsecurityinfo=True;port=3306;database=restapi;SslMode = none");
            base.OnConfiguring(optionsBuilder);
        }

    }

    public class MapPrato : IEntityTypeConfiguration<Prato>
    {
        public void Configure(EntityTypeBuilder<Prato> builder)
        {
            builder.ToTable("Prato");
            builder.HasKey(w => w.id).HasName("PK");
            builder.Property(w => w.id).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(w => w.nome).HasColumnName("NOME").HasMaxLength(255).IsRequired();
            builder.Property(w => w.idrestaurante).HasColumnName("IDRESTAURANTE").IsRequired();
            builder.HasOne(w => w.restaurante).WithMany(w => w.pratos).HasForeignKey(w => w.idrestaurante).HasConstraintName("FK").OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class MapRestaurante : IEntityTypeConfiguration<Restaurante>
    {
        public void Configure(EntityTypeBuilder<Restaurante> builder)
        {
            builder.ToTable("Restaurante");
            builder.HasKey(w => w.id).HasName("PK");
            builder.Property(w => w.id).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(w => w.nome).HasColumnName("NOME").HasMaxLength(255).IsRequired();
        }
    }

}
