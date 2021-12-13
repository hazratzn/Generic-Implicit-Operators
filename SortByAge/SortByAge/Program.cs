using System;
using SortByAge;

namespace SortByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            DataList<Person> datalist = new DataList<Person>();

            Person person = new Person("Elesger", "Esgerli" , 23);
            Person person1 = new Person("Hezret", "Niftelizade", 25);
            Person person3 = new Person("Emin", "Kazim", 22);
            Person person4 = new Person("Reshad", "Qasimzade", 21);

            datalist.Add(person4);
            datalist.Add(person3);
            datalist.Add(person);
            datalist.Add(person1);

            datalist.GetAll();

            //operators.Muqayise ele
            Console.WriteLine(person.Age > person1.Age);
            Console.WriteLine(person.Age < person1.Age);
            
            


        }
    }
}
