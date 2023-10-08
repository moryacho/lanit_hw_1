using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace дз_1
{
    internal class ClassStudent
    {
        private string Name;
        private int Age;
        public ClassBag StudentBag = new ClassBag();


        public void SetStudent(string name, int age, int capacity)
        {
            Name = name;
            Age = age;
            StudentBag.SetCapacity(capacity);
        }

        public void GreetStudent()
        {
            Console.WriteLine($"Hello! I am student {this.Name} and I am {this.Age} years old. My bag contains {this.StudentBag.GetCapacity()} liters.\n" +
                $"Today is a party day! I am going to eat pizza and drink beer all night!\n" +
                $"Are you happy for me?");
        }

        public void StidentInfo()
        {
            Console.WriteLine($"I am student {this.Name} and I am {this.Age} years old. My bag contains {this.StudentBag.GetCapacity()} liters.");
        }
       
        public void CountSatiety()
        {
            int EnoughPizza = this.Age / 3;
            int CurrentPizzaPieces = this.StudentBag.GetPizzaPieces();
            if (CurrentPizzaPieces == EnoughPizza)
            {
                Console.WriteLine("I took so many slices of pizza that it was just right for me! So smart! So smart!..");
            }
            else if (CurrentPizzaPieces > EnoughPizza)
            {
                Console.WriteLine("At the party I will be hungry, I will not have enough pizza that I took. I'll have to ask my friends to feed me!");
            }
            else
            {
                Console.WriteLine("I took too much pizza for myself. I'll share it with my friends!");
            }
        }

        public void CountDrink()
        {
            int EnoughBeer = this.Age / 5;
            int CurrentBeerBottles = this.StudentBag.GetBeerBottles();
            if (CurrentBeerBottles == EnoughBeer)
            {
                Console.WriteLine("I took the beer just right! The party will be great!");
            }
            else if (CurrentBeerBottles < EnoughBeer)
            {
                Console.WriteLine("While everyone is having fun, I will already sober up(... There is too little beer in my bag...");
            }
            else
            {
                Console.WriteLine("Ты наливаешь всем шампанского и всем становится весело\n" +
                    "Я наливаю себе водки и всем становится страшно\n" +
                    "Too much alcohol...");
            }

        }

        public void AddToBag(int PizzaForAdd, int BeerForAdd)
        {
            if (this.StudentBag.AddPizza(PizzaForAdd))
            {
                Console.WriteLine("\n" +
                    "Pizza has added to bag!)");
            }
            else
            {
                Console.WriteLine("\n" +
                    "No space for so much pizza(");
            }

            if (this.StudentBag.AddBeer(BeerForAdd))
            {
                Console.WriteLine("\n" + "Beer has added to bag!)");
            }
            else
            {
                Console.WriteLine("\n" + "\nNo space for so much beer(");
            }
        }

    }
}

/* 
 2. Создать класс Student со свойствами:

- Name
- Age
- StudentBag (тип Bag).
- Добавить метод CountSatiety
    - Принимает экземпляр класса Student
    - Возвращает строку (сообщение); Должно возвращаться три типа сообщения: переел / голоден / в самый раз.
- Добавить аналогичный метод CountDrunk
    - Принимает экземпляр класса Student
    - возвращает строку (сообщение, также один из трёх вариантов)

<aside>
💡 Cытость и степень опьянения зависит от возраста и количества кусков пиццы /бутылок пива соответственно 
(конкретные значения установить на своё усмотрение)
</aside>
 */
