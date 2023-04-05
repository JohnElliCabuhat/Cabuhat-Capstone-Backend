using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CapstoneProject.Models;

public partial class CapstoneDbContext : DbContext
{
    public CapstoneDbContext()
    {
    }

    public CapstoneDbContext(DbContextOptions<CapstoneDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Timesheet> Timesheets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("TrustServerCertificate=True;Server=DESKTOP-OHI07Q7;Database=CapstoneDB;Trusted_Connection=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>(entity =>
        {
            entity.HasKey(e => e.Bid).HasName("PK__Blogs__C6DE0D210078FDFE");

            entity.Property(e => e.Bid)
                .ValueGeneratedNever()
                .HasColumnName("BID");
            entity.Property(e => e.BlogDescription).HasMaxLength(255);
            entity.Property(e => e.BlogImage).HasMaxLength(75);
            entity.Property(e => e.BlogTitle).HasMaxLength(100);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__Employee__C190170BD6549E60");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("EID");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeName).HasMaxLength(50);
            entity.Property(e => e.ProjectId)
                .HasMaxLength(50)
                .HasColumnName("ProjectID");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Evid).HasName("PK__Events__E1CA58E5BB4BEF57");

            entity.Property(e => e.Evid)
                .ValueGeneratedNever()
                .HasColumnName("EVID");
            entity.Property(e => e.EventDescription).HasMaxLength(255);
            entity.Property(e => e.EventImage).HasMaxLength(75);
            entity.Property(e => e.EventName).HasMaxLength(100);
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Projects__C57755206F8044B5");

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("PID");
            entity.Property(e => e.ProjectDescription).HasMaxLength(255);
            entity.Property(e => e.ProjectId)
                .HasMaxLength(50)
                .HasColumnName("ProjectID");
            entity.Property(e => e.ProjectName).HasMaxLength(75);
        });

        modelBuilder.Entity<Timesheet>(entity =>
        {
            entity.HasKey(e => e.Tid).HasName("PK__Timeshee__C456D729E6D0093C");

            entity.Property(e => e.Tid)
                .ValueGeneratedNever()
                .HasColumnName("TID");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.ProjectId)
                .HasMaxLength(50)
                .HasColumnName("ProjectID");
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.Status).HasMaxLength(15);
            entity.Property(e => e.TimesheetId)
                .HasMaxLength(50)
                .HasColumnName("TimesheetID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
