using Dapper;
using mltest.Domain.Infra.DTOs;
using mltest.Domain.Models.Dashboard.Teacher;
using mltest.Domain.Repositories;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;

namespace mltest.Domain.Infra.Repositories
{
  public class TeacherRepository : ITeacherRepository
  {
    private readonly MySqlConnection _conn;
    private string _connectionString = "Server=localhost;Database=magnilearn;Uid=root;Pwd=pear0609;Allow User Variables=true;";

    public TeacherRepository()
    {
      _conn = new MySqlConnection(_connectionString);
    }

    public IEnumerable<StudentsOverallPerformance> getStudentsOverallPerformance()
    {
      string query = @"SELECT   epu.userId, epu.exerciseId, wspe.wordId, wspe.score
                       FROM 	magnilearn.exercises_per_user epu
                       INNER JOIN magnilearn.word_score_per_exercise wspe ON epu.exerciseId = wspe.exerciseId;";

      var result = _conn.Query<StudentsOverallPerformanceDTO>(query);

      List<StudentsOverallPerformance> studentsOverallPerformances = new List<StudentsOverallPerformance>();

      foreach (var userId in result.Select(x => x.userId).Distinct())
      {
        var userData = result.Where(x => x.userId == userId).ToList();
        var numberOfExercises = userData.Select(x => x.exerciseId).Distinct().Count();
        var numberOfLearnedWords = userData.Select(x => x.wordId).Count();
        var averageScore = userData.Sum(x => x.score) / numberOfLearnedWords;

        studentsOverallPerformances.Add(new StudentsOverallPerformance(userId, numberOfExercises, numberOfLearnedWords, averageScore));
      }

      return studentsOverallPerformances;
    }

    public IEnumerable<MostLearnedWords> getMostLearnedWords()
    {
      string query = @"SELECT	vw.wordId, vw.word, sum(wspe.score)/count(vw.wordId) as averageScore
                       FROM 	magnilearn.exercises_per_user epu
                       INNER JOIN magnilearn.word_score_per_exercise wspe ON epu.exerciseId = wspe.exerciseId
                       INNER JOIN magnilearn.voc_words vw ON wspe.wordId = vw.wordId
                       GROUP BY wspe.wordId;";

      var result = _conn.Query<MostLearnedWords>(query);

      return result;
    }

    public IEnumerable<BestRankedExercises> getBestRankedExercises()
    {
      string query = @"SELECT	epu.exerciseId, sum(wspe.score)/count(epu.exerciseId) as averageScore
                       FROM 	magnilearn.exercises_per_user epu
                       INNER JOIN magnilearn.word_score_per_exercise wspe ON epu.exerciseId = wspe.exerciseId
                       GROUP BY epu.exerciseId
                       ORDER BY averageScore DESC";

      var result = _conn.Query<BestRankedExercises>(query);

      return result;
    }

    public IEnumerable<UsersGrades> getUsersGrades()
    {
      string query = @"SELECT	epu.userId, sum(wspe.score)/count(epu.userId) AS averageScore
                       FROM 	magnilearn.exercises_per_user epu
                       INNER JOIN magnilearn.word_score_per_exercise wspe ON epu.exerciseId = wspe.exerciseId
                       GROUP BY epu.userId
                       ORDER BY averageScore DESC;";

      var result = _conn.Query<UsersGrades>(query);

      return result;
    }
  }
}
