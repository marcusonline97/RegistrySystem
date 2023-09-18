namespace RegistrySystem.Math
{
    public class PriceTags
    {
        public const int price = 135;
    }

    public class Employee
    {
        public string firstName;
        public string lastName;
        public int age;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        public void PerformWork()
        {
            numberOfHoursWorked++;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }
        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;

            Console.WriteLine($"{firstName} {lastName}has worked for{numberOfHours} hour(s)!");
        }

        public double RecieveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;
            Console.WriteLine($"{firstName} {lastName} has recieved a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");

            if( resetHours ) 
                numberOfHoursWorked = 0;

            return wage;
        }
    }



}


