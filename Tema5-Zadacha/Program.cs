using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Във вашата фирма постъпва проект за създаване на приложение, обслужващо „ресторант“.
Вашият софтуер трябва да описва хладилник (Fridge) и продукт (Product).
Трябва да реализирате функционалност, която да позволява добавяне и премахване на
продукти, проверка за наличност и приготвяне на ястие с определени продукти – всичко това
ще работи чрез команди, които вие ще получавате. Поредицата от команди приключва с
„END”.
Основната идея се базира на това, че т.нар. хладилник е структура, която ще съдържа n на брой
продукти. Структурата не трябва да пази продуктите в колекция! Всеки продукт пази
референция към следващия в поредицата.
Product
Всички продукти имат име и референция към следващ продукт:
● name = низ, съставен от малки и/или големи латински букви
● next = референция към следващ продукт
● Конструктор Product(string name)
● ToString() метод
Fridge
Всички хладилници имат Product head, Product tail, Count:
● head = Product, първи в поредицата
● tail = Product, последен в поредицата
● count = Брой продукти
Методи:
● public void AddProduct(string ProductName)
● public string[] CookMeal(int start, int end)
● public string RemoveProductByIndex(int index)
● public string RemoveProductByName(string name)
● public bool CheckProductIsInStock(string name)
● public string[] ProvideInformationAboutAllProducts()
Команда за добавяне на продукт
Вашето приложение трябва да обслужва следната команда за добавяне на продукти:
● Add <име> - тази команда има за цел да добави продукт с неговото име.

 */

namespace Tema5_Zadacha
{
    class Program
    {
        static Fridge fridge = new Fridge();
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "END")
            {
                string[] cmdArgs = line.Split(' ');
                switch (cmdArgs[0])
                {
                    case "Add":
                        fridge.AddProduct(cmdArgs[1]);
                        break;
                    case "Check":
                        if(fridge.CheckProductIsInStock(cmdArgs[1]))
                            Console.WriteLine("Product {0} is in stock", cmdArgs[1]);
                        else
                            Console.WriteLine("Not in stock");
                        break;
                    case "Remove":
                        try
                        {
                            int index = int.Parse(cmdArgs[1]);
                            Console.WriteLine("Removed: " + fridge.RemoveProductByIndex(index)); 
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Removed: " + fridge.RemoveProductByName(cmdArgs[1])); 
                        }
                        break;
                    case "Print":
                        foreach (var item in fridge.ProvideInformationAboutAllProducts())
                        {
                            Console.WriteLine("Product: " + item);
                        }
                        break;
                    case "Cook":
                        Console.Write("Meal cooked! Used products: ");
                        foreach (var item in fridge.CookMeal(int.Parse(cmdArgs[1]),int.Parse(cmdArgs[2])))
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        
                        break;
                }

                line = Console.ReadLine();                
            }

            Console.ReadKey();
        }
    }
    
}
/*
Add cherry
Add salami
Print
END

Add cherry
Add salami
Add eggs
Remove 1
Remove eggs
Print
Check dadadada
Check cherry
Check eggs
Add eggs
Cook 0 2
Cook 0 25
Remove 0
Print
END
 */
