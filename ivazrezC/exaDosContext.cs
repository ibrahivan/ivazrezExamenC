using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ivazrezC
{
    /**
     * Clase dbcontext que controla las relaciones y los dbset del programa
     */
    public partial class exaDosContext : DbContext
    {
        public exaDosContext()
        {
        }

        public exaDosContext(DbContextOptions<exaDosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Prestamo> Prestamos { get; set; } = null!;
        public virtual DbSet<Sequence> Sequences { get; set; } = null!;
        public virtual DbSet<Vajilla> Vajillas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Name=ConnectionStrings:CadenaConexionPostgreSQL");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.UseSerialColumns();
        
             modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.HasKey(e => e.Idreserva)
                    .HasName("prestamo_pkey");

                entity.ToTable("prestamo", "esqexados");

                entity.Property(e => e.Idreserva)
                    .ValueGeneratedNever()
                    .HasColumnName("idreserva");

                entity.Property(e => e.Fchreserva)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("fchreserva");
            });

            modelBuilder.Entity<Sequence>(entity =>
            {
                entity.HasKey(e => e.SeqName)
                    .HasName("sequence_pkey");

                entity.ToTable("sequence");

                entity.Property(e => e.SeqName)
                    .HasMaxLength(50)
                    .HasColumnName("seq_name");

                entity.Property(e => e.SeqCount)
                    .HasPrecision(38)
                    .HasColumnName("seq_count");
            });

            modelBuilder.Entity<Vajilla>(entity =>
            {
                entity.HasKey(e => e.Idelemento)
                    .HasName("vajilla_pkey");

                entity.ToTable("vajilla", "esqexados");

                entity.Property(e => e.Idelemento)
                    .ValueGeneratedNever()
                    .HasColumnName("idelemento");

                entity.Property(e => e.Cantidadelemento).HasColumnName("cantidadelemento");

                entity.Property(e => e.Codigoelemento)
                    .HasMaxLength(255)
                    .HasColumnName("codigoelemento");

                entity.Property(e => e.Descripcionelemento)
                    .HasMaxLength(255)
                    .HasColumnName("descripcionelemento");

                entity.Property(e => e.Idreserva).HasColumnName("idreserva");

                entity.Property(e => e.Nombreelemento)
                    .HasMaxLength(255)
                    .HasColumnName("nombreelemento");

                entity.HasOne(d => d.IdreservaNavigation)
                    .WithMany(p => p.Vajillas)
                    .HasForeignKey(d => d.Idreserva)
                    .HasConstraintName("fk_vajilla_idreserva");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
