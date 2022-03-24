using mltest.Domain.Models.Dashboard.Student;
using System.Collections.Generic;

namespace mltest.Domain.Repositories
{
  public interface IStudentRepository
  {
    StudentEffort getUserEffort(int userId);
    IEnumerable<StudentPerformance> getUserPerformance(int userId);
    IEnumerable<StudentLearnedVocabulary> getUserLearnedVocabulary(int userId);
    StudentProgress getUserProgress(int userId);
    IEnumerable<StudentGrade> getUserGrade(int userId);
  }
}
