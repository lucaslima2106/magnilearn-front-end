using System;

namespace mltest.Domain.Infra.DTOs
{
  public class StudentProgressDTO
  {
    public int exerciseId { get; set; }
    public DateTime createdAt { get; set; }
    public double score { get; set; }
  }
}
