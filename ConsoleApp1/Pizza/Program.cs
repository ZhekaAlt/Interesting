using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            var textFromFile = File.ReadAllText(@"..\..\..\..\pizzas.json");
            var orders = JsonSerializer.Deserialize<List<Order>>(textFromFile,
                new JsonSerializerOptions{PropertyNameCaseInsensitive = true});

            var top20 = orders
                .GroupBy(order => order.ToppingCombination)
                .Select(item => new
                {
                    toppings = item.Key,
                    count = item.Count()
                })
                .Take(20)
                .OrderByDescending(item => item.count);

            foreach (var item in top20)
            {
                var topping = item.toppings;
                Console.WriteLine($"{topping} - {item.count}");
            }

            Console.ReadKey();
        }

        class Order
        {
            public List<string> Toppings { get; set; }
            public string ToppingCombination => string.Join(", ", Toppings);
        }
    }
}

