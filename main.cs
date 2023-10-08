using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace дз_1
{ 

    internal class main
    {
        static void AddToBagGame(ClassStudent Student)
        {
            Console.Write("How many pizza pieces would you like to take: ");
            int PizzaPieces = int.Parse(Console.ReadLine());
            Console.Write("How many beer bottles would you like to take: ");
            int BeerBottles = int.Parse(Console.ReadLine());

            Student.AddToBag(PizzaPieces, BeerBottles);
            Student.StudentBag.BagInfo();
            

            if (Student.StudentBag.GetCapacity() - Student.StudentBag.GetCurrentCapacity() > 0.3)
            {
                Console.Write("Would you like to add more (y/n): ");
                string Answer = Console.ReadLine();
                if (Answer == "y")
                {
                    AddToBagGame(Student);
                }
                else
                {
                    Console.WriteLine($"Ok! I am going to a party!");
                    Student.StidentInfo();
                    Student.CountDrink();
                    Student.CountSatiety();
                }
            }
            else
            {
                Console.WriteLine("There is no space for more beer and pizza(");
                Console.WriteLine($"Ok! I am going to a party!");
                Student.StidentInfo();
                Student.CountDrink();
                Student.CountSatiety();
            }

        }



        static void Main(string[] args)
        {
            ClassStudent Student = new ClassStudent();

            Console.Write("Input student's name: ");
            string Name = Console.ReadLine();

            Console.Write("Input student's age: ");
            int Age = int.Parse(Console.ReadLine());

            Console.Write("Input student's bag capacity: ");
            int Capacity = int.Parse(Console.ReadLine());

            Student.SetStudent(Name, Age, Capacity);
            Student.GreetStudent();

            AddToBagGame(Student);




        }
    }
}