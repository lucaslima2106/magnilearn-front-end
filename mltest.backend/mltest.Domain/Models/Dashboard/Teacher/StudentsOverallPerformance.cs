namespace mltest.Domain.Models.Dashboard.Teacher
{
  public class StudentsOverallPerformance
  {
    public int userId { get; set; }
    public int numberOfExercises { get; set; }
    public int numberOfLearnedWords { get; set; }
    public double averageScore { get; set; }

    public StudentsOverallPerformance(int userId, int numberOfExercises, int numberOfLearnedWords, double averageScore)
    {
      this.userId = userId;
      this.numberOfExercises = numberOfExercises;
      this.numberOfLearnedWords = numberOfLearnedWords;
      this.averageScore = averageScore;
    }
  }
}
