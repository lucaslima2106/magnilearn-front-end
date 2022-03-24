using mltest.Domain.Models.Dashboard.Teacher;
using System.Collections.Generic;

namespace mltest.Domain.Repositories
{
  public interface ITeacherRepository
  {
    IEnumerable<StudentsOverallPerformance> getStudentsOverallPerformance();
    IEnumerable<MostLearnedWords> getMostLearnedWords();
    IEnumerable<BestRankedExercises> getBestRankedExercises();
    IEnumerable<UsersGrades> getUsersGrades();
  }
}
