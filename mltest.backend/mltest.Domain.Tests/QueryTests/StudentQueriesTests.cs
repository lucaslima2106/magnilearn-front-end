using Microsoft.VisualStudio.TestTools.UnitTesting;
using mltest.Domain.Models.Dashboard.Student;
using System.Collections.Generic;
using System.Linq;

namespace mltest.Domain.Tests.QueryTests
{
  [TestClass]
  public class StudentQueriesTests
  {
    private List<StudentEffort> _studentsEffortList;
    private List<StudentPerformance> _studentsPerformanceList;

    public StudentQueriesTests()
    {
      _studentsEffortList = new List<StudentEffort>() {
        new StudentEffort(1, 10),
        new StudentEffort(2, 20),
        new StudentEffort(3, 30)
      };

      _studentsPerformanceList = new List<StudentPerformance>() {
        new StudentPerformance(1, 1, "hello", 5),
        new StudentPerformance(2, 1, "hello", 5),
        new StudentPerformance(3, 1, "hello", 5)
      };


    }


    //[TestMethod]
    //public void StudentEffortQueryShouldReturnStudentEffortDetailsFromSpecificId()
    //{
    //  var result = _studentsEffortList.AsQueryable().Where(StudentQueries.getUserEffort(1));
    //  Assert.AreEqual(1, result.Count());
    //}

    //[TestMethod]
    //public void StudentPerformanceQueryShouldReturnStudentPerformanceList()
    //{
    //  var result = _studentsPerformanceList.AsQueryable().Where(StudentQueries.getUserPerformance(1));
    //  Assert.AreEqual(1, result.Count());
    //}



  }
}
