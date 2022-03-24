namespace mltest.Domain.Models.Dashboard.Student
{
  public class StudentGrade
  {
    public int exerciseId { get; set; }
    public double scoreAverage { get; set; }

    public StudentGrade(int exerciseId, double scoreAverage)
    {
      this.exerciseId = exerciseId;
      this.scoreAverage = scoreAverage;
    }
  }
}
