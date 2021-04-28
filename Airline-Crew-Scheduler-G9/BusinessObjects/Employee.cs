namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Pilot : Employee
    {
        public bool QualifiedForGbr10 { get; set; }
        public bool QualifiedForNu150 { get; set; }

        public Pilot(string firstName, string lastName, bool qualifiedForGbr10, bool qualifiedForNu150)
        {
            FirstName = firstName;
            LastName = lastName;
            QualifiedForGbr10 = qualifiedForGbr10;
            QualifiedForNu150 = qualifiedForNu150;
        }
    }

    public class FlightAttendant : Employee
    {
        public FlightAttendant(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }

    }
}
