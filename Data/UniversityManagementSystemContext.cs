namespace University_Management_System_API
{
    using Microsoft.EntityFrameworkCore;
    using University_Management_System_API.Model;

    public class UniversityManagementSystemContext : DbContext
    {
        public UniversityManagementSystemContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserStatus> UserStatuses { get; set; }

        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserGroupStatus> UserGroupStatuses { get; set; }
        public virtual DbSet<UserUserGroup> UserUserGroups { get; set; }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountStatus> AccountStatuses { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }

        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<FacultyStatus> FacultyStatuses { get; set; }

        public virtual DbSet<Departament> Departaments { get; set; }
        public virtual DbSet<DepartamentStatus> DepartamentStatuses { get; set; }

        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<SpecialityStatus> SpecialityStatuses { get; set; }
        public virtual DbSet<EducationalDegree> EducationalDegrees { get; set; }
        public virtual DbSet<TrainingType> TrainingTypes { get; set; }
        public virtual DbSet<SpecialityTrainingType> SpecialityTrainingTypes { get; set; }

        public virtual DbSet<Discipline> Disciplines { get; set; }
        public virtual DbSet<DisciplineStatus> DisciplineStatuses { get; set; }

        public virtual DbSet<Lecture> Lectures { get; set; }
        public virtual DbSet<LectureStatus> LectureStatuses { get; set; }

        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomStatus> RoomStatuses { get; set; }

        public virtual DbSet<TeacherDiscipline> TeacherDisciplines { get; set; }
        public virtual DbSet<TeacherDisciplineStatus> TeacherDisciplineStatuses { get; set; }
        public virtual DbSet<ApiSession> ApiSessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Password)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }            
    }
}
