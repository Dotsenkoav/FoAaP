using System;
using System.Collections.Generic;

namespace ProjectByDotsenko
{
    internal class LabSevenTaskOne
    {

        private Random rand = new Random();
        public void Run()
        {
            List<Baggage> list = GenerateBaggage();
            GetQtyPassage(list);
        }

        public void GetQtyPassage(List<Baggage> list)
        {
            int counter = 0;
            foreach (Baggage baggage in list)
            {
                Console.WriteLine($"Багаж {counter + 1}");
                Console.WriteLine($"Кол-во вещей: {baggage.qtyItem}");
                Console.WriteLine($"Общий вес: {baggage.weight}");
                Console.WriteLine("==========================");
                if (baggage.qtyItem > 2)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Количество пассажиров, имеющих более двух вещей: {counter}");
        }

        public List<Baggage> GenerateBaggage()
        {
            List<Baggage> listBaggages = new List<Baggage>();
            for (int i = 0; i < 10; i++)
            {
                listBaggages.Add(new Baggage(GenerateInteger(), GenerateFloat()));
            }
            return listBaggages;
        }
            
        public struct Baggage
        {
            public int qtyItem;
            public float weight;

            public Baggage(int qty, float weightItems)
            {
                this.qtyItem = qty;
                this.weight = weightItems;
            }
        }

        public int GenerateInteger()
        {
            return rand.Next(1, 5);
        }

        public float GenerateFloat()
        {
            return (float)(rand.NextDouble() * 29.0 + 1.0);
        }
    }
}