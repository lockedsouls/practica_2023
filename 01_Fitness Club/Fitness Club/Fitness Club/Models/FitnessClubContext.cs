using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Fitness_Club.Models;

public partial class FitnessClubContext : DbContext
{
    public FitnessClubContext()
    {
    }

    public FitnessClubContext(DbContextOptions<FitnessClubContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Personal> Personals { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-B38G05Q;User ID=ichavamp;Password=admin1234;Database=fitness_club;Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clients__3213E83F482AA8B6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cash)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("cash");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Subscription).HasColumnName("subscription");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.SubscriptionNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.Subscription)
                .HasConstraintName("FK__Clients__subscri__403A8C7D");
        });

        modelBuilder.Entity<Personal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personal__3213E83F67C48826");

            entity.ToTable("Personal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cash)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("cash");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.Role).WithMany(p => p.Personals)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Personal__role_i__398D8EEE");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3213E83F9D34F071");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Role1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("role");
            entity.Property(e => e.Salary)
                .HasColumnType("money")
                .HasColumnName("salary");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Services__3213E83F00D75C35");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("price");
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Subscrip__3213E83FE3F09B11");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FreeService).HasColumnName("free_service");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");

            entity.HasOne(d => d.FreeServiceNavigation).WithMany(p => p.Subscriptions)
                .HasForeignKey(d => d.FreeService)
                .HasConstraintName("FK__Subscript__free___52593CB8");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
