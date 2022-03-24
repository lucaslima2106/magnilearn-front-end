namespace mltest.Domain.Models.Dashboard.Teacher
{
  public class MostCompletedExercises
  {
    public int exerciseId { get; set; }
    public int total { get; set; }

    public MostCompletedExercises(int exerciseId, int total)
    {
      this.exerciseId = exerciseId;
      this.total = total;
    }
  }
}
