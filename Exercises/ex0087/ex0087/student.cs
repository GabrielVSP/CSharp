using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex0087
{
    internal class Student
    {

        private int id;
        private string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void displayDetails()
        {
            Console.WriteLine($"Student ID: {id} \nStudent Name: {name}");
        }

        public void patch()
        {
            Console.Write("Enter new student ID:");
            var newId = Console.ReadLine();

            while (newId.GetType() != typeof(int) )
            {

                try
                {
                    
                    id = int.Parse(newId);
                    break;

                } catch ( Exception e ) { 

                    Console.WriteLine(e.Message);
                    Console.Write("Enter new student ID:");
                    newId = Console.ReadLine();

                }

            }

        }

    }

}
