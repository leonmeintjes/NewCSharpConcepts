using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explicit Contstructor
            ClassConstructors ThisConstruct = new ClassConstructors(37,"Koos Du Plessis");
            Console.WriteLine($"This guy is called {ThisConstruct.Name}");
            Console.WriteLine($"This guy is {ThisConstruct.Age} years old");
            
            //Default Constructor - Method 1
            ClassConstructors ThisConstruct2 = new ClassConstructors();
            ThisConstruct2.Age = 32;
            ThisConstruct2.Name = "Son Ofagun";
            Console.WriteLine($"This guy2 is called {ThisConstruct2.Name}");
            Console.WriteLine($"This guy2 is {ThisConstruct2.Age} years old");

            //Default Constructor - Method 2
            ClassConstructors ThisConstruct3 = new ClassConstructors()
            {
                Age = 22, Name = "Sannie Vanderskoor"
            
            };
            Console.WriteLine($"This guy3 is called {ThisConstruct3.Name}");
            Console.WriteLine($"This guy3 is {ThisConstruct3.Age} years old");

            //Non static methods - (Does not have the word static and must be instantiated before use)
            //Called from the instance of a class
            StaticAndNonStaticMethods ReturnTheAnswer = new StaticAndNonStaticMethods();
            double thisAnswer = ReturnTheAnswer.NonStaticMethod("200");
            Console.WriteLine("This non static answer is " + thisAnswer );
            
            //Static methods - (has the word static and can be called without instantiating the class) 
            //Called directly from the class
            double thirdAnswer = StaticAndNonStaticMethods.StaticMethod("200");
            
            //Handling exceptions - example of try catch block
            TryCatch thisTryCatch = new TryCatch();
            thisTryCatch.Work();

            //Collections and arrays
            //Array Example
            CollectionsArraysListsDictionaries ThisClass = new CollectionsArraysListsDictionaries();
            

            //Interfaces - Exmaples and demo
            Console.WriteLine("Document 1 is of class Document");
            Console.WriteLine("-------------------------------");
            Document doc1 = new Document();
            doc1.Reformat("MyFile1");
            doc1.Read("MyFile1");
            doc1.Write("MyFile1");
            doc1.Speak();

            Console.WriteLine("Document 2 is of interface IStorable");
            Console.WriteLine("------------------------------------");
            IStorable doc2 = new Document();
            doc2.Read("MyFile2");
            doc2.Write("MyFile2");
            //doc2.Speak(); cannot call this method as it does not belong to IStorable

            Console.WriteLine("Document 3 is of interface IRecording");
            Console.WriteLine("------------------------------------");
            IRecording doc3 = new Document();
            doc3.Speak();
            //doc3.Read("MyFile3"); cannot call this method as it does not belong to IRecording

            //Abstract classes : Example
            //We have an abstract class called Control, both MyButton and MyListbox inherit from 
            //Control and therefore must override the method called Draw() as set in the Control class
            //Porpoerties of Abstract Classes
            //-Cannot be instatiated 
            //-Contains at least one abstract method
            //-Serves as a base class

            Console.WriteLine("Abstract Classes");
            Console.WriteLine("----------------");
            List<Control> controls = new List<Control>();
            MyButton button = new MyButton(0,100,"Click Me");
            MyListBox listbox = new MyListBox(100,300,new List<string>());
            MyButton cancelButton = new MyButton(150,100,"Cancel");
            controls.Add(button);
            controls.Add(listbox);
            controls.Add(cancelButton);

            foreach (Control control in controls)
            {
             control.Draw();    
            }


            //Important operators
            //nullable integer
            int? ThisX = null;
            Console.WriteLine($"x is {ThisX}");

            //count will only return something if there is somehting otherwise null
            List<string>? thisauthors = null;
            int? ThisCount = thisauthors?.Count;

            //Ternary operator
            string thismessage = ThisCount == null
                ? "count is null"
                : "count is not null";
            Console.WriteLine($"Message is {thismessage}");

            //coalescant control - if null then return zero as integer in this case cannot be null
            int howMany = thisauthors?.Count ?? 0;
            Console.WriteLine($"howmany = {howMany}");

            //not null check
            thisauthors = new List<string>() { "Author one", "Author two" };
            howMany = thisauthors?.Count ?? 0;
            Console.WriteLine($"howmany is {howMany}");

            //LINQ examples
            //Any 
            var listOne = new List<int>() { 1, 2, 3, 4, 5 };
            var listTwo = new List<int>();

            bool hasAny = listOne.Any();
            bool hasAnyTwo = listTwo.Any();

            Console.WriteLine($"Has Any 1 equals {hasAny}");
            Console.WriteLine($"Has Any 2 equals {hasAnyTwo}");

            //Lamda expression within the Any 
            bool hasThree = listOne.Any(x => x == 3);
            bool hasFive = listTwo.Any(x => x == 5);

            Console.WriteLine($"Has 3 in list one is {hasThree}");
            Console.WriteLine($"Has 5 in list one is {hasFive}");

            //Take 
            var takeFive = listOne.Take(5)
            .Select(x => x * 10);
            foreach (int value in takeFive)
            {
                Console.WriteLine($"Value multiplied by 10 is {value}");
            }


            //Distinct --> Non duplicated numbers / objects in the list
            var listWithDuplicates = new List<int> { 1, 1, 1, 2, 3, 4, 5, 6, 6, 7, 8, 7, 8, 9 };
            var distinctList = listWithDuplicates.Distinct();
            foreach (int ValueDistinct in distinctList)
            {
                Console.WriteLine($"Number if distinct list{ValueDistinct}");
            }

            // Linq Where function  - Filters
            List<string> fruits = new List<string> { "apple", "passionfruit", "banana", "mango","orange", "blueberry", "grape", "strawberry" };
            IEnumerable<string> query = fruits.Where(fruit => fruit.Length < 6);
            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }
            
            // LINQ select - looping and populated lists Ienumerable objects
            List<string> Newquery = new List<string>();
            Newquery = fruits.Select((fruit, fruitindex) => {
                Console.WriteLine($"The values are {fruit}");
                return fruit;
            }).ToList();
            

            Console.ReadLine();

            // Test Commits

        }
    }
}