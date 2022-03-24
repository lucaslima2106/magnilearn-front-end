namespace mltest.Domain.Models.Dashboard.Student
{
  public class StudentPerformance
  {
    public int exerciseId { get; set; }
    public string word { get; set; }
    public double score { get; set; }

    protected StudentPerformance() { }

    public StudentPerformance(int exerciseId, string word, double score)
    {
      this.exerciseId = exerciseId;
      this.word = word;
      this.score = score;
    }
  }
}
