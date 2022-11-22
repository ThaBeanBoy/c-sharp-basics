using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1{
    class Program{
        static void Main(string[] args){
            //Testing the default args
            Console.WriteLine(GreetUser());

            
            Console.WriteLine(GreetUser("Lebron", "James"));

            //Testing the named args
            Console.WriteLine(GreetUser(
                Name: "Steph",
                Surname: "Curry"
            ));

            Console.WriteLine("\nPress Enter To Exit");
            Console.ReadLine();
        }

        static string GreetUser(string Name = "John", string Surname = "Doe"){
            return String.Format("Hello there {0} {1}", Name, Surname);
        }
    }
}
