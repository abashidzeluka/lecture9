namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[8];

            employees[0] = new Employee("John", "Smith", new DateTime(1996, 1, 1), Country.Georgia, Gender.Male, Contacts.Email, "john.smith@gmail.com");
            employees[1] = new Employee("Anna", "Brown", new DateTime(1990, 3, 15), Country.Germany, Gender.Female, Contacts.Phone, "+995-555-123-456");
            employees[2] = new Employee("Luca", "Rossi", new DateTime(1985, 7, 22), Country.Italy, Gender.Male, Contacts.Phone, "+995-599-234-567");
            employees[3] = new Employee("Maria", "Garcia", new DateTime(1992, 11, 5), Country.Spain, Gender.Female, Contacts.Email, "maria.garcia@yahoo.com");
            employees[4] = new Employee("David", "Müller", new DateTime(1988, 4, 30), Country.Germany, Gender.Male, Contacts.Email, "david.muller@outlook.com");
            employees[5] = new Employee("Sofia", "Marino", new DateTime(1995, 8, 18), Country.Italy, Gender.Female, Contacts.Phone, "+995-577-345-678");
            employees[6] = new Employee("George", "Beridze", new DateTime(1993, 6, 12), Country.Georgia, Gender.Male, Contacts.Email, "george.Beridze@hotmail.com");
            employees[7] = new Employee("Elena", "Ruiz", new DateTime(1991, 2, 27), Country.Spain, Gender.Female, Contacts.Email, "elena.ruiz@gmail.com");

            Employee.FilterByCountry(employees, Country.Georgia);

        }
    }
}
