using System;

class Display
{
    public void DisplayPerson(Person thePerson)
    {
        Console.WriteLine("Name: {0}", thePerson.Name);
        Console.WriteLine("Age: {0}", thePerson.Age);
    }

    public void DisplayPersons(Person[] data)
    {
        int loopVar;
        loopVar = 0;
        while(loopVar < 5)
        {
            Console.WriteLine("Name {0}: {1}\tAge: {2}", loopVar+1, data[loopVar].Name, data[loopVar].Age);
            loopVar++;
        }
    }
}