using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_1
{
    internal class ClassBag
    {
        private int PizzaPieces = 0;
        private int BeerBottles = 0;
        private int Capacity;
        private double CurrentCapacity = 0;

        public void SetCapacity(int capacity)
        {
            this.Capacity = capacity;
        }

        public int GetCapacity()
        {
            return this.Capacity;
        }

        public int GetPizzaPieces()
        {
            return this.PizzaPieces;
        }

        public int GetBeerBottles()
        {
            return this.BeerBottles;
        }

        public double GetCurrentCapacity()
        {
            return this.CurrentCapacity;
        }

        public bool CheckCapacity(double CapacityAdd)
        {
            if (this.CurrentCapacity + CapacityAdd > this.Capacity)
            {
                return false;
            }
            return true;

        }

        public void BagInfo()
        {
            Console.WriteLine($"\n" +
                $"Capacity: {this.Capacity}\n" +
                $"Current Capacity: {Math.Round(this.CurrentCapacity, 1)}\n" +
                $"Pizza Pieces: {this.PizzaPieces}\n" +
                $"Beer Bottles: {this.BeerBottles}");
        }

        public bool AddPizza(int PizzaPiecesForAdd)
        {
            if (CheckCapacity(0.3 * PizzaPiecesForAdd))
            {
                this.PizzaPieces += PizzaPiecesForAdd;
                this.CurrentCapacity += PizzaPiecesForAdd * 0.3;
                return true;
            }
            return false;
        }

        public bool AddBeer(int BeerForAdd)
        {
            if (CheckCapacity(0.5 * BeerForAdd))
            {
                this.BeerBottles += BeerForAdd;
                this.CurrentCapacity += BeerForAdd * 0.5;
                return true;
            }
            return false;
        }

    }
}


/* 
 * Создать класс Bag со свойствами: 
 - PizzaPieces (количество кусков пиццы)
- BeerBottles (количество бутылок пива)
- Capacity (вместимость рюкзака в литрах).
- Добавить метод AddPizza:
    - Принимает количество кусков пиццы и экземпляр класса Bag
    - Возвращает bool: true, если влезет, false - если не влезет
- Добавить аналогичный метод AddBeer:
    - Принимает количество бутылок и экземпляр Bag
    - Возвращает bool

<aside>
💡 Принять, что одна бутылка - 0,5 литра, кусок пиццы - 0,3 литра; при расчёте учесть, что в сумке пицца и пиво лежат вместе.

</aside>
 */
