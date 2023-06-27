using Microsoft.EntityFrameworkCore;

namespace SignalRNotify.Models;

public partial class SignalRdbContext : DbContext
{
    public SignalRdbContext()
    {
    }

    public SignalRdbContext(DbContextOptions<SignalRdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HubConnection> HubConnections { get; set; }
    public virtual DbSet<Notification> Notifications { get; set; }
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HubConnection>(entity =>
        {
            entity.ToTable("HubConnection");

            entity.Property(e => e.ConnectionId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.ToTable("Notification");

            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Message)
                .HasMaxLength(int.MaxValue)
                .IsUnicode(false);

            entity.Property(e => e.MessageType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NotificationDateTime)
                .HasDefaultValue(DateTime.Now);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        base.OnModelCreating(modelBuilder);
    }
}
