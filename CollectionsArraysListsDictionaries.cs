using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NewCSharpConcepts
{
    public class CollectionsArraysListsDictionaries
    {

        public CollectionsArraysListsDictionaries()
        {
            //Array
            Person[] people = new Person[7];
            people[0] = new Person {Name = "Koos", Surname = "Du Plessis"};
            people[1] = new Person {Name = "Sannie", Surname = "Du Plessis"};
            people[2] = new Person {Name = "Jannie", Surname = "Van Skoor"};
            people[3] = new Person {Name = "Manie", Surname = "Moolman"};
            //Display a specific person 
            Console.WriteLine($"The Name of person in 4 position is {people[3].Name} {people[3].Surname}");
            //An exception when retireving a array element not yet initialised
            try
            {
                Console.WriteLine($"Person in position 7 (not yet initialised) is {people[7].Name} {people[7].Surname}");
            }
            catch (Exception e)
            {

                Console.WriteLine(
                    $"The exception is thrown by referencing an array element that was not initialised is : {e.ToString()}");
            }


            //First method to loop through array
            Console.WriteLine("Loop through array using For loop");
            Console.WriteLine("---------------------------------");
            for (int j = 0; j <= people.Length; j++)
            {
                try
                {
                    if (people[j] != null)
                    {
                        Console.WriteLine($"Person in position {j.ToString()} is {people[j].Name} {people[j].Surname}");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine($"Person in position {j.ToString()} is Empty");
                }
            }

            //Second method to loop through array
            Console.WriteLine("Loop through array using ForEach loop");
            Console.WriteLine("-------------------------------------");
            foreach (var ThisPerson in people)
            {
                try
                {
                    if (ThisPerson != null)
                    {
                        Console.WriteLine($"Person is {ThisPerson.Name} {ThisPerson.Surname}");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine($"Person is Empty");
                }
            }

            //Creating and working with LIST of people objects

            List<Person> peopleList = new List<Person>();

            //Method 1 for adding to the LIST
            Person JohnSmith = new Person() {Name = "John", Surname = "Smith"};
            peopleList.Add(JohnSmith);
            //Method 2 for adding to the LIST
            peopleList.Add(new Person() {Name = "Koos", Surname = "Van der Merwe"});

            //Displaying the contents of a LIST
            Console.WriteLine("Displaying objects in a LIST<t>");
            Console.WriteLine("-------------------------------");
            int k = 0;
            foreach (Person ThisPartPerson in peopleList)
            {
                k++;
                Console.WriteLine($"Person {k.ToString()} is {ThisPartPerson.Name} {ThisPartPerson.Surname}");
            }

            //Using Disctionary (Key value pairs)
            Dictionary<string,Person> PeopleDict = new Dictionary<string,Person>();

            //Adding to dictionary (key value pair) -- Method 1
            Person Johnny = new Person() {Name = "John" , Surname = "Smith"};
            string key = "Johnny";
            PeopleDict.Add(key, Johnny);

            //Adding to dictionary (key value pair) -- Method 2
            PeopleDict.Add("Koos",new Person() {Name = "Koos",Surname = "Van Der Merwe"} );

            // Extracting values in dictionary by using the key
            Console.WriteLine("Working with Dictionaries");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Finding only for person with key = Johnny equals {PeopleDict["Johnny"].Name} {PeopleDict["Johnny"].Surname}");
            Console.WriteLine($"Finding only for person with key = Koos equals {PeopleDict["Koos"].Name} {PeopleDict["Koos"].Surname}");


        }
    }
}