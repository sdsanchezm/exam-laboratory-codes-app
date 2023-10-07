using exam_laboratory_codes_app.Data;
using exam_laboratory_codes_app.Models;

namespace exam_laboratory_codes_app.Services
{
    public class LabexamService : ILabexamService
    {
        readonly LabexamContext _dbContext;

        public LabexamService(LabexamContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task Delete(Guid id)
        {
            var exam = _dbContext.Find<Labexam>(id);

            if (exam != null)
            {
                _dbContext.Remove(exam);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IEnumerable<Labexam> GetAll()
        {
            return _dbContext.Labexams;
        }

        public async Task Save(Labexam le)
        {
            _dbContext.Add(le);
            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<Labexam> SearchKeyword(string q)
        {
            var qr = _dbContext.Labexams
                .Where(exam =>
                    exam.ExamName.Contains(q) || 
                    exam.CommonName.Contains(q)
                ).ToList();

            return qr;
        }

        public async Task Update(Guid id, Labexam le)
        {
            var examInDb = _dbContext.Labexams.Find(id);

            if (examInDb != null)
            {
                await Console.Out.WriteLineAsync("not null here!-------------");
                //await Console.Out.WriteLineAsync(id.ToString());
                //await Console.Out.WriteLineAsync(le.FastingRequired.ToString());
                examInDb.ExamId = Guid.Parse(id.ToString());
                examInDb.ExamNumber = le.ExamNumber;
                examInDb.ExamName = le.ExamName;
                examInDb.CommonName = le.CommonName;
                examInDb.FastingRequired = le.FastingRequired;
                examInDb.PreparationDescription = le.PreparationDescription;
                examInDb.ObservationForLaboratory = le.ObservationForLaboratory;
                examInDb.ExamPlace = le.ExamPlace;
                examInDb.Schedule = le.Schedule;
                examInDb.ExamCode = le.ExamCode;
                examInDb.CupsCode = le.CupsCode;
                examInDb.SampleDescription = le.SampleDescription;
                examInDb.SampleStability = le.SampleStability;
                examInDb.ClinicUtility = le.ClinicUtility;
                examInDb.MountingDays = le.MountingDays;
                examInDb.TimeResults = le.TimeResults;
                examInDb.SampleTechnic = le.SampleTechnic;
                examInDb.ProcessingPlace = le.ProcessingPlace;

                await _dbContext.SaveChangesAsync();
            }
        }
    }

    public interface ILabexamService
    {
        IEnumerable<Labexam> GetAll();
        Task Save(Labexam le);
        Task Update(Guid id, Labexam le);
        Task Delete(Guid id);
        IEnumerable<Labexam> SearchKeyword(string q);
    }
}
