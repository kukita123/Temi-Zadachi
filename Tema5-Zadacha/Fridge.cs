using System;
using System.Collections.Generic;
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
● CookMeal<int startIndex, int endIndex>

Команда за добавяне на продукт
Вашето приложение трябва да обслужва следната команда за добавяне на продукти:
● Add <име> - тази команда има за цел да добави продукт с неговото име.

Вашето приложение във всеки един момент може да получи заявка да отпечата информация за всички налични продукти. 
Командата за това е следната:
● Print - отпечатва информация за всички продукти в структурата във формат: Product {name} 
● За успешна реализация трябва да реализирате ваша версия на ToString() метода за класа Product. 
● RemoveProductByIndex -  Трябва  да  бъде  премахнат  елемент,  който  се  намира  на посочения индекс. 
Тъй като вашата структура не използва индексиране, удобен похват би бил използването на брояч. При успешно намиране и 
премахване на Product трябва да върнете неговото име, което ще бъде отпечатано на конзолата от Main метод-а. 
При ненамиране на такъв Product, трябва да бъде върната null стойност. 
● RemoveProductByName - Трябва да бъде премахнат първият елемент, на който името отговаря  на  подаденото.  
При  успешно  намиране  и  премахване  на  Product  трябва  да върнете неговото име, което ще бъде отпечатано на конзолата 
от Main метод-а. При ненамиране на такъв Product, трябва да бъде върната null стойност. 
● CheckProductIsInStock - Трябва да бъде намерен елемент, на който името отговаря на подаденото. При успешно намиране 
Product трябва да върнете true в обратен случай false 
● CookMeal<int startIndex, int endIndex> - Трябва да бъдат намерени всички продукти от startIndex до endIndex. 
Имената на всички намерени продукти трябва да бъдат събрани в стрингов масив, който да бъде върнат от метода.
*/

namespace Tema5_Zadacha
{
    public class Fridge
    {
        private class Product
        {
            public string name;
            public Product next;

            public Product(string name)
            {
                this.name = name;
            }
            public override string ToString()
            {
                return this.name;
            }
        }

        private Product head;
        private Product tail;
        private int count;

        private bool isEmpty()
        {
            return head == null;
        }

        public void AddProduct(string ProductName)
        {
            Product product = new Product(ProductName);

            if (isEmpty())
            {
                head = tail = product;
                count++;
            }
            else
            {
                tail.next = product;
                tail = product;
                count++;
            }
        }

        private int indexOf(string item)
        {
            int index = 0;
            var current = head;

            while (current != null)
            {
                if (current.name == item)
                {
                    return index;
                }

                current = current.next;
                index++;
            }
            return -1;
        }

        public bool CheckProductIsInStock(string item)
        {
            return indexOf(item) != -1;
        }

        private Product getPrevious(Product product)
        {
            var current = head;
            while (current != null)
            {
                if (current.next == product)
                {
                    return current;
                }

                current = current.next;
            }
            return null;
        }        

        public string RemoveProductByIndex(int index)
        {
            if (index >= count)
                return null;
            else
            {
                if (isEmpty())
                    return null;
                if (head == tail)
                {
                    string nameToReturn = head.name;
                    head = tail = null;
                    count = 0;
                    return nameToReturn;
                }
                if (index == 0)
                {
                    string nameToReturn = head.name;
                    var second = head.next;
                    head.next = null;
                    head = second;
                    return nameToReturn;
                }
                else
                {
                    var current = head;
                    int tempIndex = 0;

                    while(current != null)
                    {
                        if(index == tempIndex)
                        {
                            string nameToReturn = current.name;

                            var previous = getPrevious(current);
                            var following = current.next;

                            previous.next = following;

                            current = null;
                            count--;

                            return nameToReturn;
                        }    
                        
                        current = current.next;
                        tempIndex++;                        
                    }
                    return null;
                }
            }
        }

        public string RemoveProductByName(string item)
        {
            int itemIndex = indexOf(item);
            return RemoveProductByIndex(itemIndex);
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            List<string> products = new List<string>();
            var current = head;

            while( current != null)
            {
                products.Add(current.ToString());
                current = current.next;
            }

            string result = string.Join(" ", products);
            return result.Split(' ');
        }

        public string[] CookMeal(int start, int end)
        {
            if (start >= end)
                return null;

            if (end - start > count)
                return null;            
            
            string[] result = new string[end - start + 1];
            var current = head;

            for (int i = 0; i < start; i++)
            {
                current = current.next;
            }

            int index = 0;
            for (int i = start; i <= end; i++)
            {
                result[index] = current.name;
                index++;
                current = current.next;
            }

            return result;
        }
    }

}
