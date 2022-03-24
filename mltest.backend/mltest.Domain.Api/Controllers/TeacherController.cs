using Microsoft.AspNetCore.Mvc;
using mltest.Domain.Models.Dashboard.Teacher;
using mltest.Domain.Repositories;

namespace mltest.Domain.Api.Controllers;

[ApiController]
[Route("magnilearn/dashboard/teacher")]
public class TeacherController : ControllerBase
{
  private readonly ITeacherRepository _teacherRepository;

  public TeacherController(ITeacherRepository teacherRepository)
  {
    _teacherRepository = teacherRepository;
  }

  [HttpGet("students-overall-performance")]
  public IEnumerable<StudentsOverallPerformance> getStudentsOverallPerformance()
  {
    return _teacherRepository.getStudentsOverallPerformance();
  }

  [HttpGet("get-most-learned-words")]
  public IEnumerable<MostLearnedWords> getMostLearnedWords()
  {
    return _teacherRepository.getMostLearnedWords();
  }

  [HttpGet("get-best-ranked-exercises")]
  public IEnumerable<BestRankedExercises> getBestRankedExercises()
  {
    return _teacherRepository.getBestRankedExercises();
  }

  [HttpGet("get-users-grades")]
  public IEnumerable<UsersGrades> getUsersGrades()
  {
    return _teacherRepository.getUsersGrades();
  }
}
