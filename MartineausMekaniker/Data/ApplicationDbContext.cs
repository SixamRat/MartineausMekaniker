using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MartineausMekaniker.Models;

namespace MartineausMekaniker.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Kund> Kunder { get; set; }
        public DbSet<Fordon> Fordon { get; set; }
        public DbSet<Bokning> Bokningar { get; set; }
        public DbSet<Tidrapport> Tidrapporter { get; set; }
        public DbSet<Faktura> Fakturor { get; set; }
        public DbSet<FakturaRad> FakturaRader { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Personal>()
                .Property(p => p.Timpris)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Tidrapport>()
                .Property(t => t.TimmarArbetat)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Faktura>()
                .Property(f => f.Arbetskostnad)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Faktura>()
                .Property(f => f.Materialkostnad)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Faktura>()
                .Property(f => f.Summa)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Faktura>()
                .Property(f => f.Moms)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Faktura>()
                .Property(f => f.Totalt)
                .HasPrecision(18, 2);

            modelBuilder.Entity<FakturaRad>()
                .Property(fr => fr.Antal)
                .HasPrecision(18, 2);

            modelBuilder.Entity<FakturaRad>()
                .Property(fr => fr.Pris)
                .HasPrecision(18, 2);

            modelBuilder.Entity<FakturaRad>()
                .Property(fr => fr.Summa)
                .HasPrecision(18, 2);

           

            modelBuilder.Entity<Bokning>()
                .HasOne(b => b.Kund)
                .WithMany(k => k.Bokningar)
                .HasForeignKey(b => b.KundId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Bokning>()
                .HasOne(b => b.Fordon)
                .WithMany(f => f.Bokningar)
                .HasForeignKey(b => b.FordonId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Bokning>()
                .HasOne(b => b.Personal)
                .WithMany(p => p.Bokningar)
                .HasForeignKey(b => b.PersonalId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Tidrapport>()
                .HasOne(t => t.Bokning)
                .WithMany(b => b.Tidrapporter)
                .HasForeignKey(t => t.BokningId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Faktura>()
                .HasOne(f => f.Kund)
                .WithMany(k => k.Fakturor)
                .HasForeignKey(f => f.KundId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Faktura>()
                .HasOne(f => f.Bokning)
                .WithMany()
                .HasForeignKey(f => f.BokningId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}