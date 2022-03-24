using Microsoft.AspNetCore.Mvc;
using mltest.Domain.Models.Dashboard.Student;
using mltest.Domain.Repositories;

namespace mltest.Domain.Api.Controllers;

[ApiController]
[Route("magnilearn/dashboard/student/{studentId}")]
public class StudentController : ControllerBase
{
  private readonly IStudentRepository _studentRepository;

  public StudentController(IStudentRepository studentRepository)
  {
    _studentRepository = studentRepository;
  }

  [HttpGet("effort")]
  public StudentEffort getUserEffort(int studentId)
  {
    return _studentRepository.getUserEffort(studentId);
  }

  [HttpGet("performance")]
  public IEnumerable<StudentPerformance> getUserPerformance(int studentId)
  {
    return _studentRepository.getUserPerformance(studentId);
  }

  [HttpGet("learnedVocabulary")]
  public IEnumerable<StudentLearnedVocabulary> getUserLearnedVocabulary(int studentId)
  {
    return _studentRepository.getUserLearnedVocabulary(studentId);
  }

  [HttpGet("progress")]
  public StudentProgress getUserProgress(int studentId)
  {
    return _studentRepository.getUserProgress(studentId);
  }

  [HttpGet("grade")]
  public IEnumerable<StudentGrade> getUserGrade(int studentId)
  {
    return _studentRepository.getUserGrade(studentId);
  }
}
