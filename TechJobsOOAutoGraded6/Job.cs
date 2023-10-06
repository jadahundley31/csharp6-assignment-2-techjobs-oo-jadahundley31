using System;
using System.Xml.Linq;

namespace TechJobsOOAutoGraded6
{
	public class Job
	{
        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string Name, Employer EmployerName, Location EmployerLocation, PositionType JobType, CoreCompetency JobCoreCompetency) : this()
        {
            this.Name = Name;
            this.EmployerName = EmployerName;
            this.EmployerLocation = EmployerLocation;
            this.JobType = JobType;
            this.JobCoreCompetency = JobCoreCompetency;
        }


        // TODO: Task 3: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            String emptyField = "Data not available";
            if (Name == null || Name == "")
            {
                Name = emptyField;
            }
            if (EmployerName == null || EmployerName.Value == "")
            {
                EmployerName.Value = emptyField;
            }
            if (EmployerLocation == null || EmployerLocation.Value == "")
            {
                EmployerLocation.Value = emptyField;
            }
            if (JobType == null || JobType.Value == "")
            {
                JobType.Value = emptyField;
            }
            return "\n" + "ID: " + Id + "\n" +
                "Name: " + Name + "\n" +
                "Employer: " + EmployerName.Value + "\n" +
                "Location: " + EmployerLocation.Value + "\n" +
                "Position Type: " + JobType.Value + "\n" +
                "Core Competency: " + JobCoreCompetency.Value + "\n";
        }


    }
}

