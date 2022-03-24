using System;

namespace mltest.Domain.Models.Dashboard.Student
{
  public class StudentProgress
  {
    public int studentId { get; set; }
    public DateTime dtIni { get; set; }
    public DateTime dtEnd { get; set; }
    public int numberOfExercises { get; set; }
    public double scoreAverageOverTime { get; set; }

    protected StudentProgress() { }

    public StudentProgress(int studentId, DateTime dtIni, DateTime dtEnd, int numberOfExercises, double scoreAverageOverTime)
    {
      this.studentId = studentId;
      this.dtIni = dtIni;
      this.dtEnd = dtEnd;
      this.numberOfExercises = numberOfExercises;
      this.scoreAverageOverTime = scoreAverageOverTime;
    }
  }
}
