using Dapper;
using Microsoft.Extensions.Configuration;
using mltest.Domain.Infra.DTOs;
using mltest.Domain.Models.Dashboard.Student;
using mltest.Domain.Repositories;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mltest.Domain.Infra.Repositories
{
  public class StudentRepository : IStudentRepository
  {
    private readonly MySqlConnection _conn;
    private string _connectionString = "Server=localhost;Database=magnilearn;Uid=root;Pwd=pear0609;Allow User Variables=true;";

    public StudentRepository()
    {
      _conn = new MySqlConnection(_connectionString);
    }


    public StudentEffort getUserEffort(int studentId)
    {
      string query = @"SELECT userId as studentId, COUNT(exerciseId) AS numberOfExercises
                       FROM   magnilearn.exercises_per_user
                      WHERE	  userId = @studentId;";

      var result = _conn.QuerySingle<StudentEffort>(query, new { studentId });

      return result;
    }

    public IEnumerable<StudentPerformance> getUserPerformance(int studentId)
    {
      string query = @"SELECT	epu.exerciseId, vc.word, wspe.score
                       FROM 	magnilearn.exercises_per_user epu
                       INNER JOIN magnilearn.word_score_per_exercise wspe ON epu.exerciseId = wspe.exerciseId
                       INNER JOIN magnilearn.voc_words vc ON wspe.wordId = vc.wordId
                       WHERE	epu.userId = @studentId
                       GROUP BY epu.exerciseId, vc.word, wspe.score;";

      var result = _conn.Query<StudentPerformance>(query, new { studentId });

      return result;
    }

    public IEnumerable<StudentLearnedVocabulary> getUserLearnedVocabulary(int studentId)
    {
      string query = @"SELECT	wspe.wordId, vw.word, wspe.score as scoreAverage
                       FROM 	magnilearn.exercises_per_user epu
                       INNER JOIN magnilearn.word_score_per_exercise wspe ON epu.exerciseId = wspe.exerciseId
                       INNER JOIN magnilearn.voc_words vw ON wspe.wordId = vw.wordId
                       WHERE	epu.userId = @studentId
                       GROUP BY wspe.wordId, vw.word, wspe.score;";

      var result = _conn.Query<StudentLearnedVocabulary>(query, new { studentId });

      return result;
    }

    public StudentProgress getUserProgress(int studentId)
    {
      string query = @"SELECT	epu.exerciseId, epu.createdAt, wspe.score
                       FROM 	magnilearn.exercises_per_user epu
                       INNER JOIN magnilearn.word_score_per_exercise wspe ON epu.exerciseId = wspe.exerciseId
                       WHERE	epu.userId = @studentId
                       ORDER BY epu.exerciseId ASC;";

      var result = _conn.Query<StudentProgressDTO>(query, new { studentId });

      DateTime dtIni = result.Min(x => x.createdAt);
      DateTime dtEnd = result.Max(x => x.createdAt);
      var totalDays = result.Select(x => x.createdAt.Date).Distinct().Count();
      int numberOfExercises = result.Select(x => x.exerciseId).Distinct().Count();
      double scoresSum = result.Sum(x => x.score);
      double scoreAverageOverTime = scoresSum / totalDays;

      return new StudentProgress(studentId, dtIni, dtEnd, numberOfExercises, scoreAverageOverTime);
    }

    public IEnumerable<StudentGrade> getUserGrade(int studentId)
    {
      string query = @"SELECT	epu.exerciseId, wspe.score
                       FROM 	magnilearn.exercises_per_user epu
                       INNER JOIN magnilearn.word_score_per_exercise wspe ON epu.exerciseId = wspe.exerciseId
                       WHERE	epu.userId = @studentId
                       ORDER BY epu.exerciseId ASC;";

      var result = _conn.Query<StudentGradeDTO>(query, new { studentId });

      List<StudentGrade> studentGrades = new List<StudentGrade>();

      foreach (var exerciseId in result.Select(x => x.exerciseId).Distinct())
      {
        var exerciseData = result.Where(x => x.exerciseId == exerciseId).Select(x => x);
        var scoreAverage = exerciseData.Sum(x => x.score) / exerciseData.Count();

        studentGrades.Add(new StudentGrade(
          exerciseId, scoreAverage          
          ));
      }

      return studentGrades;

    }
  }
}
