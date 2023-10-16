using System;

namespace _20231016_Task01_Okumura{
    public class CompanyMember{
        // Init
        string Name;
        int Age;
        string Role;
        int Id;

        public CompanyMember(string name, int age, string role, int id){
            Name = name;
            Age = age;
            Role = role;
            Id = id;
        }

        public void PrintInfo(){
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Id: {Id}");
        }
    }
}
