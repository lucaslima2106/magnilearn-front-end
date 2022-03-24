namespace mltest.Domain.Infra.DTOs
{
  public class StudentsOverallPerformanceDTO
  {
    public int userId { get; set; }
    public int exerciseId { get; set; }
    public int wordId { get; set; }
    public double score { get; set; }
  }
}
