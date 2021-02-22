using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Разполагате със следния програмен код:
Program.cs

List input = Console.ReadLine().Split(' ').Select().ToList();
while (true)
{
List curent = Console.ReadLine().Split(' ').ToList();
if (curent[0] == "print")
{
Console.WriteLine("[{0}]", string.Join(", ", input));
break;
}
if (curent[0] == "add")
{
int index = int.Parse(curent[1]);
input.Add(index, element);
}
if (curent[0] == "contains")
{
int serachedNumber = int.Parse(curent[1]);
Console.WriteLine(input.Contains(serachedNumber));
}
if (curent[0] == "remove")
{
input.Remove(removedNumber);
}
}

Открийте и поправете грешките във вече написания програмен код, така че да се въведе списък
от цели числа от конзолата и списък от команди, които се изпълняват върху списъка.
Допълнете кода, като командите, които трябва да се изпълняват са, както следва:
● add <индекс> <елемент> – вмъква елемент на зададената позиция (елементите
надясно от тази позиция включително се изместват надясно).
● addMany <индекс> <елемент 1> <елемент 2> … <елемент n> – добавя множество
от елементи на дадената позиция.
● contains <елемент> – изпечатва индекса на първото срещане на зададения елемент
(ако съществува) в списъка или -1, ако елемента не е открит.
● remove <индекс> – премахва елемента, намиращ се на зададената позиция.
● shift <позиции> – отмества всеки елемент от списъка съответния брой позиции наляво
(с ротация). Например, [1, 2, 3, 4, 5] -> shift 2 -> [3, 4, 5, 1, 2].
● sumPairs – сумира елементите на всички двойки в списъка (първа + втора, трета +
четвърта, …). Например, [1, 2, 4, 5, 6, 7, 8] -> [3, 9, 13, 8].
● print – спира да получава повече команди и извежда последното състояние на списъка.
 */
namespace Tema2_Zadacha
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();            

            while (true)
            {
                List<string> curent = Console.ReadLine().Split(' ').ToList();

                if (curent[0] == "print")
                {
                    Console.WriteLine("[{0}]", string.Join(", ", input));
                    break;
                }
                if (curent[0] == "add")
                {
                    int index = int.Parse(curent[1]);
                    int element = int.Parse(curent[2]);
                    input.Insert(index, element);
                }
                if (curent[0] == "contains")
                {
                    int searchedNumber = int.Parse(curent[1]);
                    for(int i = 0; i < input.Count; i++)
                    {
                        if (input[i] == searchedNumber)
                        {
                            Console.WriteLine(i);
                            break;
                        }                         
                    }
                    if(!input.Contains(searchedNumber))
                        Console.WriteLine(-1);
                }
                if (curent[0] == "remove")
                {
                    int index = int.Parse(curent[1]);
                    input.RemoveAt(index);
                }
                if (curent[0] == "addMany")
                {
                    int index = int.Parse(curent[1]);

                    List<int> set = new List<int>();
                    for (int i = 2; i < curent.Count; i++)                    
                        set.Add(int.Parse(curent[i]));

                    input.InsertRange(index, set); 
                    
                }
                if (curent[0] == "shift")
                {
                    int number = int.Parse(curent[1]);
                    List<int> set1 = new List<int>();
                    List<int> set2 = new List<int>();
                    for (int i = 0; i < number; i++)
                        set1.Add(input[i]);
                    for (int i = number; i < input.Count; i++)
                        set2.Add(input[i]);
                    foreach (var item in set1)
                    {
                        set2.Add(item);
                    }
                    //input = set2;
                    input.Clear();
                    foreach (var item in set2)
                    {
                        input.Add(item);
                    }
                }
                if (curent[0] == "sumPairs")
                {
                    List<int> set = new List<int>();

                    for(int i = 0, j = 1; i < input.Count; i += 2, j += 2)
                    {
                        if (j < input.Count)
                            set.Add(input[i] + input[j]);
                        else
                        {
                            input.Add(0);
                            set.Add(input[i] + input[j]);
                        }                        
                    }

                    //input.Clear();
                    //foreach (var item in set)
                    //{
                    //    input.Add(item);
                    //}
                    input = set;
                }
            }

            Console.ReadKey();
        }
    }
}
/*
 1 2 3 4 5
 addMany 5 9 8 7 6 5
 contains 15
 remove 3
 shift 1
 print
 * */


// user: tester
// password: tester

/*
1 2 1 2 1 2 1 2 1 2 1 2
sumPairs
sumPairs
addMany 0 -1 -2 -3
print
 * 
 */
