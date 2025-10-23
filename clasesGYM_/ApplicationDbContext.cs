using System;
using Microsoft.EntityFrameworkCore;
using clasesGYM_;
public class AplicationDbContext: DbContext
{
    public DbSet<Factura> Facturas { get; set; }
    public DbSet<Pago> Pagos { get; set; }
    public DbSet<Suscripcion> Suscripciones { get; set; }   
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Clase> Clases { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
    "Server=localHost;Database=SistemaGym;Trusted_Connection=True;TrustServerCertificate=True;"
);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Factura>().ToTable("Facturas");
        modelBuilder.Entity<Pago>().ToTable("Pagos");
        modelBuilder.Entity<Suscripcion>().ToTable("Suscripciones");
        modelBuilder.Entity<Cliente>().ToTable("Clientes");
        modelBuilder.Entity<Clase>().ToTable("Clases");


    }

}
