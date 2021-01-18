using System;
using System.Linq;
using System.Collections.Generic;

namespace Task06_Store_Boxes
{
    class Item
    {
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {   

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double PriceBox { get; set; }
        public object Name { get; internal set; }
        public object Price { get; internal set; }
    }
    class Program
    {  
        static void Main(string[] args)
        {
            List<Box> boxInShop = new List<Box>();
            List<Item> itemsInShop = new List<Item>();
                        
            while (true)
            {
                string[] boxDatas = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(boxDatas[0] == "end")
                {
                    break;
                }

                Item nextItem = new Item()
                {
                    Name = boxDatas[1],
                    Price = double.Parse(boxDatas[3])
                };

                Box nextBox = new Box()
                {
                    // {Serial Number} {Item Name} {Item Quantity} {itemPrice}
                    SerialNumber = boxDatas[0],
                    Quantity = int.Parse(boxDatas[2]),
                    PriceBox = int.Parse(boxDatas[2]) * nextItem.Price
                };

                itemsInShop.Add(nextItem);
                boxInShop.Add(nextBox);

                //itemsInShop.OrderBy(x=>)

            }

            
            
            foreach (Box toPrint in boxInShop)
            {
                Console.WriteLine(toPrint.SerialNumber);
                Console.WriteLine($"-- {toPrint.Name} - {toPrint.Price}: {toPrint.Quantity}");
                Console.WriteLine($"-- {toPrint.PriceBox}");
            }
        }
    }
}
