using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Models
{
    public partial class BirdClinicContext : DbContext
    {
        public BirdClinicContext()
        {
        }

        public BirdClinicContext(DbContextOptions<BirdClinicContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }
        public virtual DbSet<PatientBird> PatientBirds { get; set; }
        public virtual DbSet<RegistrationSchedule> RegistrationSchedules { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceMore> ServiceMores { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<StatusBooking> StatusBookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local); Database=BirdClinic; Uid=sa; Pwd=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK_Account_1");

                entity.ToTable("Account");

                entity.Property(e => e.Username)
                    .HasMaxLength(15)
                    .HasColumnName("username")
                    .IsFixedLength(true);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .HasColumnName("phone")
                    .IsFixedLength(true);

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.GenderNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.Gender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Gender");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Role");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("Booking");

                entity.Property(e => e.BookingId).HasColumnName("booking_id");

                entity.Property(e => e.BookingDate)
                    .HasColumnType("date")
                    .HasColumnName("booking_date");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.PatiendId).HasColumnName("patiendId");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UsernameCustomer)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("username_customer")
                    .IsFixedLength(true);

                entity.Property(e => e.UsernameDoctor)
                    .HasMaxLength(15)
                    .HasColumnName("username_doctor")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Patiend)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.PatiendId)
                    .HasConstraintName("FK_Booking_PatientBird");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Booking_Service");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Booking_Status_Booking");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.Gender1);

                entity.ToTable("Gender");

                entity.Property(e => e.Gender1)
                    .ValueGeneratedNever()
                    .HasColumnName("gender");

                entity.Property(e => e.GenderName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("gender_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MedicalRecord>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("MedicalRecord");

                entity.Property(e => e.RecordId).HasColumnName("record_id");

                entity.Property(e => e.BookingId).HasColumnName("booking_id");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.TotalFee).HasColumnName("total_fee");
            });

            modelBuilder.Entity<PatientBird>(entity =>
            {
                entity.HasKey(e => e.PatientId)
                    .HasName("PK_Patient");

                entity.ToTable("PatientBird");

                entity.Property(e => e.PatientId).HasColumnName("patientId");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.BirdName)
                    .HasMaxLength(10)
                    .HasColumnName("bird_name")
                    .IsFixedLength(true);

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("username")
                    .IsFixedLength(true);

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.GenderNavigation)
                    .WithMany(p => p.PatientBirds)
                    .HasForeignKey(d => d.Gender)
                    .HasConstraintName("FK_PatientBird_Gender");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.PatientBirds)
                    .HasForeignKey(d => d.SpeciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_Species");
            });

            modelBuilder.Entity<RegistrationSchedule>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.Date });

                entity.ToTable("RegistrationSchedule");

                entity.Property(e => e.Username)
                    .HasMaxLength(15)
                    .HasColumnName("username")
                    .IsFixedLength(true);

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.RegistrationSchedules)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistrationSchedule_Account");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("role_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("service_name")
                    .IsFixedLength(true);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<ServiceMore>(entity =>
            {
                entity.HasKey(e => new { e.RecordId, e.ServiceId });

                entity.ToTable("ServiceMore");

                entity.Property(e => e.RecordId).HasColumnName("record_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.ServiceMores)
                    .HasForeignKey(d => d.RecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceMore_MedicalRecord");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceMores)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceMore_Service");
            });

            modelBuilder.Entity<Species>(entity =>
            {
                entity.Property(e => e.SpeciesId).HasColumnName("species_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<StatusBooking>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("Status_Booking");

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("status_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
