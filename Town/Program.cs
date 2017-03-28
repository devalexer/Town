using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class Program
    {
        static void Main(string[] args)
        {

            var houses = new List<House>();
            houses.Add("Home");
            houses.Add(new House() { Name = "Casa" });
            houses.Add(new House() { Name = "Crib" });
            houses.Add(new House() { Name = "Residence" });

            List<School> banks = new List<Bank>();
            banks.Add(new Bank() { Name = "Scrooge National Bank" });
            banks.Add(new Bank() { Name = "Miserly Community Bank" });
            banks.Add(new Bank() { Name = "Predatory Bank" });
            banks.Add(new Bank() { Name = "Parsimonious Intl. Bank" });

           var schools = new List<School>();
            schools.Add(new School() { Name = "Knowledgable College" });
            schools.Add(new School() { Name = "Brainy High School" });
            schools.Add(new School() { Name = "Astute Middle School" });
            schools.Add(new School() { Name = "Inventive Elementary School" });

            var myHouse = new House("brick");

            //Add a constructor to the bank that sets the amount of money
            //public amountOfMoney()
            //{

            //}





            //for person to walk
            var myHouse = new House("brick");

            var hank = new Person { Name = "Hank" };

            myHouse.Occupants.Add(hank);

        }
    }
}


//Demo all the functions you've created in explorer mode by creating different instances of each type 
//    you've made and calling each function and property on them.

//    Add a constructor to the bank that sets the amount of money
//    Add a constructor to the school that sets the number of teachers and the numbers of students
//    Add a constructor to the house that sets the number of baths and number of bedrooms
//    Update the TeacherStudentRadio to return the lowest form (example: 2:10, should be 1:5)
