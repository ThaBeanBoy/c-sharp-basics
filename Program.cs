using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1{
    class Program{
        static void Main(string[] args){
            User[] Users = { 
                new User(name: "Lebron", surname: "James"),
                new User(name: "Steph", surname: "Curry"),
                new User(name: "Kevin", surname: "Durant"),
            };

            foreach (User Player in Users)
                Player.Greet();

            Console.WriteLine("\nPress Enter To Exit");
            Console.ReadLine();
        }

        static string GreetUser(string Name = "John", string Surname = "Doe"){
            return String.Format("Hello there {0} {1}", Name, Surname);
        }

        class User
        {
            //Properties
            private const string DEFAULT_NAME = "John";
            private const string DEFAULT_SURNAME = "Doe";
            private string _Name;
            private string _Surname;

            public static int num_of_users = 0;
            int _User_Id;

            public string UserId{ get; }

            public string Name {
                get {
                    return _Name;
                } set
                {
                    //Validating string
                    _Name = ValidateString(value, DEFAULT_NAME);
                } 
            }

            public string Surname
            {
                get
                {
                    return _Surname;
                }
                set
                {
                    //Validating string
                    _Surname = ValidateString(value, DEFAULT_SURNAME);
                }
            }

            //constructor
            public User(string name = DEFAULT_NAME, string surname = DEFAULT_SURNAME)
            {
                //Incrementing the number of users
                _User_Id++;

                //Setting the properties
                _Name = ValidateString(name, "John");
                _Surname = ValidateString(surname, "Doe");
                _User_Id = num_of_users;
            }


            //Methods
            public void Greet()
            {
                Console.WriteLine(String.Format("Hi, my name is {0} & my surname is {1}", Name, Surname));
            }

            // Helper methods
            private string ValidateString(string str_value, string str_fallBackString)
            {
                return (str_value == "") ? str_fallBackString : str_value;
            }
        }
    }
}
