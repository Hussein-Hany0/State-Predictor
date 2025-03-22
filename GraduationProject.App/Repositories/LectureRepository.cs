using GraduationProject.App.Models;

namespace GraduationProject.App.Repositories
{
    public interface ILectureRepository
    {
        public void CreateLecture(Lecture lecture);

        public List<Lecture> GetLectures(int instructorId);
    }
    public class LectureRepository : ILectureRepository
    {
        private readonly PredatorContext _context;

        public LectureRepository(PredatorContext context)
        {
            _context = context;
        }

        public void CreateLecture(Lecture lecture)
        {
            _context.Add(lecture);

            _context.SaveChanges();
        }

        public List<Lecture> GetLectures(int instructorId)
        {
            return _context.Lectures.Where(lecture => lecture.UserId == instructorId).ToList();
        }
    }
}
