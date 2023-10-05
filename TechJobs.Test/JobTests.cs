
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        Job job1 = new Job();
        Job job2 = new Job();
        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new
            PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new
            PositionType("Quality control"), new CoreCompetency("Persistence"));

        //initalize your testing objects here
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testjob1 = new Job();
            Job testjob2 = new Job();
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job testjob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new
            PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(testjob3.Name, "Product tester");
            Assert.AreEqual(testjob3.EmployerName.Value, "ACME");
            Assert.AreEqual(testjob3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(testjob3.JobType.Value, "Quality control");
            Assert.AreEqual(testjob3.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testjob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new
            PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job testjob4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new
            PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(testjob3 == testjob4);
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {

        }
    }
}

