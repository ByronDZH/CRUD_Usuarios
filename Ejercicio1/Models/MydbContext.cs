using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Ejercicio1.Models;

public partial class MydbContext : DbContext
{
    public MydbContext()
    {
    }

    public MydbContext(DbContextOptions<MydbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Idusuarios).HasName("PRIMARY");

            entity.ToTable("usuarios");

            entity.Property(e => e.Idusuarios)
                .HasColumnType("int(11)")
                .HasColumnName("idusuarios");
            entity.Property(e => e.Apellido)
                .HasMaxLength(45)
                .HasColumnName("apellido");
            entity.Property(e => e.Coreo)
                .HasMaxLength(45)
                .HasColumnName("coreo");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(45)
                .HasColumnName("nombre");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
