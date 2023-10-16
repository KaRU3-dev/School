using System;

namespace _20231016_Task01_Okumura{
    public class Program{
        public static void Main(string[] args){
            // Create Company Member
            Console.WriteLine("Enter Name:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Role:");
            String role = Console.ReadLine();
            Console.WriteLine("Generating Id...");
            int id = GenID();
            Console.WriteLine($"Id: {id}");

            CreateCMember cMember = new CreateCMember(name, age, role, id);

            // Show Profile
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n"); // Clear console
            cMember.ShowProfile();




            int GenID(){
                Random rnd = new Random();
                int Id = rnd.Next(1000, 9999);

                return Id;
            }
        }
    }
}
