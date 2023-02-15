using System;

namespace tttask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("max alcoholPercent:");
            
            Drink drink1 = new Drink { AlcoholPercent = 15 };
            Drink drink2 = new Drink { AlcoholPercent = 45 };
            
            

            Store store = new Store();
            store.AddProduct(drink1);
            store.AddProduct(drink2);

            Console.WriteLine(store.AlcoholPercentLimit());
            Console.WriteLine(drink1.AlcoholPercent);
            Console.WriteLine("------------------");

            var arr = store.GetDrinkProducts();
            foreach (var item in arr)
            {
              Console.WriteLine($"{item.AlcoholPercent} {item.Price}");                


            }
        }
    }
}
