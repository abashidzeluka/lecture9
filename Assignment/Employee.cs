using System;

namespace Assignment
{
    internal class Employee
    {
        private string _name;
        private string _surname;
        private DateTime _dateOfbirth;

        public Employee(string name, string surname, DateTime dateofbirth, Country country, Gender gender, Contacts contacts, string contactvalue)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateofbirth;
            Country = country;
            Gender = gender;
            Contacts = contacts;
            ContactValue = contactvalue;
        }

        public string ContactValue { get; set; }


        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be empty.");
                    return;
                }
                _name = value;
            }
        }


        public string Surname 
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Surname cannot be empty.");
                    return;
                }
                _surname = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfbirth; }
            set 
            { 
                if (value >= DateTime.Now) 
                { 
                    Console.WriteLine("Birth date must be in the past.");
                    return;
                }
                _dateOfbirth = value;
            }
            
        }



        public Country Country { get; set; }
        
        public Gender Gender { get; set; }

        public Contacts Contacts { get; set; }

        public int GetAge()
        {
             return DateTime.Now.Year - DateOfBirth.Year;
        }       

        public override string? ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Age: {GetAge()}, Country: {Country}, Contact - {Contacts}: {ContactValue}";
        }
    }

    enum Country
    {
        Georgia,
        Germany,
        Italy,
        Spain
    }

    enum Gender
    {
        Male,
        Female
    }

    enum Contacts
    {
        Phone,
        Email
    }
}
