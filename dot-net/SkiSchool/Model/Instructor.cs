using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiSchool.Model
{
    public class Instructor
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Instructor() { }

        public Instructor(string firstName, string lastName, string phoneNumber, string userName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            UserName = userName;
            Password = password;
        }

/*
        public instructor(instructor instructor)
        {
            firstname = instructor.firstname;
            lastname = instructor.lastname;
            phonenumber = instructor.phonenumber;
            username = instructor.username;
            password = instructor.password;
        }*/
    }
}
