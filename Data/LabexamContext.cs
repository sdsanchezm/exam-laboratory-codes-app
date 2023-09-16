using Microsoft.EntityFrameworkCore;
using exam_laboratory_codes_app.Models;

namespace exam_laboratory_codes_app.Data
{
    public class LabexamContext : DbContext
    {

        public DbSet<Labexam> labexams { get; set; }

        public LabexamContext(DbContextOptions<LabexamContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            List<Labexam> labexamInitial = new List<Labexam>();
            labexamInitial.Add(new Labexam() { ExamId = Guid.Parse("875c4dfe-6f68-48b9-a12d-c5cae64844f2"), ExamNumber = "223344", ExamName = "Gripa", CommonName = "Gripa comun", FastingRequired = true } );

            modelBuilder.Entity<Labexam>(exam =>
            {
                exam.ToTable("Labexam");
                exam.HasKey(p => p.ExamId);
                exam.Property(p => p.ExamNumber).IsRequired();
                exam.Property(p => p.ExamName).IsRequired();
                exam.Property(p => p.CommonName).IsRequired();
                exam.Property(p => p.FastingRequired).IsRequired();
                exam.Property(p => p.PreparationDescription).IsRequired(false);
                exam.Property(p => p.ObservationForLaboratory).IsRequired(false);
                exam.Property(p => p.ExamPlace).IsRequired(false);
                exam.Property(p => p.Schedule).IsRequired(false);
                exam.Property(p => p.ExamCode).IsRequired(false);
                exam.Property(p => p.CupsCode).IsRequired(false);
                exam.Property(p => p.SampleDescription).IsRequired(false);
                exam.Property(p => p.SampleStability).IsRequired(false);
                exam.Property(p => p.ClinicUtility).IsRequired(false);
                exam.Property(p => p.MountingDays).IsRequired(false);
                exam.Property(p => p.TimeResults).IsRequired(false);
                exam.Property(p => p.SampleTechnic).IsRequired(false);
                exam.Property(p => p.ProcessingPlace).IsRequired(false);
                exam.HasData(labexamInitial);
            });

        }

    }
}
