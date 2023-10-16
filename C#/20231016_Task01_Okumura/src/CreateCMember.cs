using System;
using System.Reflection.Metadata.Ecma335;

namespace _20231016_Task01_Okumura{
    public class CreateCMember : CompanyMember{
        // Init
        string Name;
        int Age;
        string Role;
        int Id;

        public CreateCMember(string name, int age, string role, int id) : base(name, age, role, id){}

        // Request Name
        public string RequestName(){
            Console.WriteLine("Enter Name:");
            return Name = Console.ReadLine();
        }

        // Request Age
        public int RequestAge(){
            Console.WriteLine("Enter Age:");
            return Age = int.Parse(Console.ReadLine());
        }

        // Request Role
        public string RequestRole(){
            Console.WriteLine("Enter Role:");
            return Role = Console.ReadLine();
        }

        public void ShowProfile(){
            PrintInfo();
        }
    }
}
