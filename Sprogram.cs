using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACKS
{
    class Sprogram

    {
        static Cart Scart;
        static void Main(string[] args)
        {
            int option = 0;

            Scart = new Cart();

            while (option != 5)
            {
                Console.WriteLine("\n\t\tMenu - select an option");
                Console.WriteLine("\t\t-----------------------");
                Console.WriteLine("\t\t1. Add an item to cart");
                Console.WriteLine("\t\t2. Remove an item to cart");
                Console.WriteLine("\t\t3. Return an item to cart");
                Console.WriteLine("\t\t4. View Shopping Cart");
                Console.WriteLine("\t\t5. Exit");
                Console.WriteLine("Option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        bool repeat = true;
                        while (repeat)
                        {
                            Console.Write("Enter item name(type 's' to stop): ");
                            var itemName = Console.ReadLine();

                            if (itemName != "s")
                                Scart.Push(itemName);

                            repeat = itemName == "s" ? false : true;
                        }
                        ShowCartItems();
                        break;
                    case 2:
                        Scart.Pop();
                        ShowCartItems();
                        break;
                    case 3:
                        Scart.Return();
                        ShowCartItems();
                        break;
                    case 4:
                        ShowCartItems();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option !");
                        break;

                }
            }
        }
        public static void ShowCartItems()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tCart Items");
            Console.WriteLine("\t----------");
            Scart.viewCart();
            Console.WriteLine("\t----------");
            Console.ForegroundColor= ConsoleColor.Red;
              
        }
    }
    
}
