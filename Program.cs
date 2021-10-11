using System;

namespace LectureOnObjectsAsArraysAndPassedParameters
{
    //Lecture on Arrays of Objects
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ArrayOfObjects[] data = new ArrayOfObjects[5];      //creating an array of objects
    //        int loopVar;

    //        //Initialize each objects by its constructors
    //        loopVar = 0;
    //        while (loopVar < 5)
    //        {
    //            data[loopVar] = new ArrayOfObjects();
    //            loopVar++;
    //        }

    //        loopVar = 0;
    //        while (loopVar < 5)
    //        {
    //            Console.Write("Enter Name {0}: ", loopVar + 1);
    //            data[loopVar].Name = Console.ReadLine();
    //            Console.Write("Enter Age: ");
    //            data[loopVar].Age = Int32.Parse(Console.ReadLine());
    //            loopVar++;
    //        }

    //        loopVar = 0;
    //        while (loopVar < 5)
    //        {
    //            Console.WriteLine("Name {0}: {1}        Age: {2}", loopVar + 1, data[loopVar].Name, data[loopVar].Age);
    //            loopVar++;
    //        }
    //        Console.ReadKey();
    //    }
    //}

    //Lecture on Objects Passed as Arguments
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person[] data = new Person[5];
            Display displays = new Display();
            int loopVar = 0;

            Console.Clear();
            person1.Name = "Zante P";
            person1.Age = 44;
            person2.Name = "Rhea Mae";
            person2.Age = 33;

            while (loopVar < 5)
            {
                data[loopVar] = new Person();
                loopVar++;
            }

            loopVar = 0;
            while (loopVar < 5)
            {
                Console.Write("Enter Name {0}: ", loopVar + 1);
                data[loopVar].Name = Console.ReadLine();
                Console.Write("Enter Age: ");
                data[loopVar].Age = Convert.ToInt32(Console.ReadLine());
                loopVar++;
            }

            displays.DisplayPerson(person1);
            displays.DisplayPerson(person2);
            displays.DisplayPersons(data);

            Console.ReadKey();

        }
    }
}
