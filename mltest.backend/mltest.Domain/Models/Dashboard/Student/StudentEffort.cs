namespace mltest.Domain.Models.Dashboard.Student
{
  public class StudentEffort
  {
    public int studentId { get; private set; }
    public int numberOfExercises { get; private set; }

    protected StudentEffort() { }

    public StudentEffort(int studentId, int numberOfExercises)
    {
      this.studentId = studentId;
      this.numberOfExercises = numberOfExercises;
    }
  }
}
