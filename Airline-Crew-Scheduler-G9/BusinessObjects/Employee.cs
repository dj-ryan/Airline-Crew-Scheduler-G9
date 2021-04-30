namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Employee
    {

        public string employeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
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
        public FlightAttendant(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;

        }

    }

}

