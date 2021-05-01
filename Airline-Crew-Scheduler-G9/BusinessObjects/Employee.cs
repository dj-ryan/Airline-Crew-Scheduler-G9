namespace Airline_Crew_Scheduler_G9.BusinessObjects
{
    public class Employee
    {

        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool Gbr10Certification { get; set; }
        public bool Nu150Certification{ get; set; }

        public Employee(int employeeID, string firstName, string lastName, bool gbr10Cert, bool nu150Cert)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Gbr10Certification = gbr10Cert;
            Nu150Certification = nu150Cert;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    //public class Pilot : Employee
    //{
    //    public bool QualifiedForGbr10 { get; set; }
    //    public bool QualifiedForNu150 { get; set; }

    //    public Pilot(int employeeID, string firstName, string lastName, bool qualifiedForGbr10, bool qualifiedForNu150) 
    //    {
    //        QualifiedForGbr10 = qualifiedForGbr10;
    //        QualifiedForNu150= qualifiedForNu150;
    //    }
    //}

    //public class FlightAttendant : Employee
    //{
    //    public FlightAttendant(int employeeID, string firstName, string lastName) : base(employeeID, firstName,
    //        lastName)
    //    {

    //    }


    //}

}

