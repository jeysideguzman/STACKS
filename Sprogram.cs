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
                Console.WriteLine("\t\t1. Add an iten to cart");
                Console.WriteLine("\t\t2. Undo");
                Console.WriteLine("\t\t3. Redo");
                Console.WriteLine("\t\t4. View Cart");
                Console.WriteLine("\t\t5. Exit");
                Console.WriteLine("Option ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        bool repeat = true;
                        while (repeat)
                        {
                            Console.Write("Enter item name(type 'n' to stop): ");
                            var itemName = Console.ReadLine();

                            if (itemName != "n")
                                Scart.Add(itemName);

                            repeat = itemName == "n" ? false : true;
                        }
                        ShowCartItems();
                        break;
                    case 2:
                        Scart.Undo();
                        ShowCartItems();
                        break;
                    case 3:
                        Scart.Redo();
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\tCart Items");
            Console.WriteLine("\t----------");
            Scart.viewCart();
            Console.WriteLine("\t----------");
            Console.ForegroundColor= ConsoleColor.White;
              
        }
    }
    
}
