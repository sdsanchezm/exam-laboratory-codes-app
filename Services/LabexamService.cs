using exam_laboratory_codes_app.Data;
using exam_laboratory_codes_app.Models;

namespace exam_laboratory_codes_app.Services
{
    public class LabexamService : ILabexamService
    {
        LabexamContext _dbContext;

        public LabexamService(LabexamContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task Delete(Guid id)
        {
            var exam = await _dbContext.FindAsync<Labexam>(id);
            if (exam != null)
            {
                _dbContext.Remove(exam);
                await _dbContext.SaveChangesAsync();
            }
        }

        public IEnumerable<Labexam> GetAll()
        {
            return _dbContext.labexams;
        }

        public async Task Save(Labexam le)
        {
            _dbContext.Add(le);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Guid id, Labexam le)
        {
            var examInDb = _dbContext.labexams.Find(id);

            if (examInDb != null)
            {
                examInDb.ExamNumber = le.ExamNumber;
                examInDb.ExamName = le.ExamName;
                examInDb.CommonName = le.CommonName;

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
    }
}
