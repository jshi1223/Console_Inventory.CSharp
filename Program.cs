using System;

namespace Inventory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int prodFix = 5;
            string[] prodName = new string[prodFix];
            int[] prodStock = new int[prodFix];
            int[] prodPieces = new int[prodFix];

            // Input Products
            for (int i = 0; i < prodFix; i++)
            {
                Console.WriteLine($"\nEnter your product {i + 1}:");
                Console.Write("Product Name: ");
                prodName[i] = Console.ReadLine();

                Console.Write("Total Stock: ");
                prodStock[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Pieces: ");
                prodPieces[i] = Convert.ToInt32(Console.ReadLine());
            }

            int num;
            do
            {
                // Menu
                Console.WriteLine("\n======================");
                Console.WriteLine("       MENU");
                Console.WriteLine("======================");
                Console.WriteLine("1. Display Products");
                Console.WriteLine("2. Search Product");
                Console.WriteLine("3. Total Inventory");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an Option: ");
                num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("\n📦 Product List:");
                        for (int i = 0; i < prodFix; i++)
                        {
                            Console.WriteLine($"{i + 1}. {prodName[i]} - Stock: {prodStock[i]}, Pieces: {prodPieces[i]}");
                        }
                        break;

                    case 2:
                        Console.Write("\n🔍 Enter product name to search: ");
                        string search = Console.ReadLine();
                        bool found = false;

                        for (int i = 0; i < prodFix; i++)
                        {
                            if (prodName[i].Equals(search, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"✅ Found: {prodName[i]} - Stock: {prodStock[i]}, Pieces: {prodPieces[i]}");
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("❌ Product not found.");
                        }
                        break;

                    case 3:
                        int totalInventory = 0;
                        for (int i = 0; i < prodFix; i++)
                        {
                            totalInventory += prodStock[i] * prodPieces[i];
                        }
                        Console.WriteLine($"\n📊 Total Inventory: {totalInventory} items");
                        break;

                    case 4:
                        Console.WriteLine("👋 Exiting...");
                        break;

                    default:
                        Console.WriteLine("❗ Invalid option. Try again.");
                        break;
                }

            } while (num != 4);
        }
    }
}
