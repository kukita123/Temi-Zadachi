using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/*
Да се напише програма, която трябва да обработва информация за продукти в JSON вид.
Създайте клас Product със свойства за:
● Id (int) – номер на продукта
● Name (string) – име на продукта
● Price (decimal) – цена на продукта
● Stock(int) – наличност на продукта
● Expiry (DateTime) – срок на годност на продукта

Подзадачи:
● Преобразувайте данните от клас Product към JSON
● Преобразувайте JSON към Product
Изберете подходяща външна библиотека за работа с JSON за реализиране на подзадачите.

Фрагмент:
Product.cs
public class Product
{
public int Id { get; set; }
public string Name { get; set; }
public decimal Price { get; set; }
public int Stock { get; set; }
public DateTime Expiry { get; set; }
}
Program.cs
class Program
{
static void Main(string[] args)
{
// part 1
List<Product> list1 = new List<Product>();
list1.Add(new Product()  
{  
Id = 1,  
Name = "Beer",  
Price = 1.2m,  
Stock = 5,  
Expiry = new DateTime(2020, 03, 31)  
});
list1.Add(new Product()  
{  
Id = 2,  
Name = "Fries",  
Price = 2.4m,  
Stock = 10,  
Expiry = new DateTime(2020, 03, 31)  
});
var json1 = JsonConvert.SerializeObject(list1);
Console.WriteLine(json1);
// part 2
var json2 = @"[{Id:1,Name:Beer,Price:1.2,Stock:5,Expiry:2020‐03‐31},
 {Id:2,Name:Fries,Price:2.4,Stock:10,Expiry:2020‐03‐31}]";
var list2 = JsonConvert.DeserializeObject<List<Product>>(json2);
foreach (var item in list2) Console.WriteLine(item.Name);
}
}
*/
namespace Tema11_Zadacha
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime Expiry { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // part 1
            List<Product> list1 = new List<Product>();
            list1.Add(new Product()
            {
                Id = 1,
                Name = "Beer",
                Price = 1.2m,
                Stock = 5,
                Expiry = new DateTime(2020, 03, 31)
            });
            list1.Add(new Product()
            {
                Id = 2,
                Name = "Fries",
                Price = 2.4m,
                Stock = 10,
                Expiry = new DateTime(2020, 03, 31)
            });

            var json = JsonSerializer.Create();
            //json.Serialize(, list1);
        }
    }
}
