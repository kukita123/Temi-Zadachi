using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Robot> robots = new List<Robot>();
            List<Citizen> citizens = new List<Citizen>();

            var line = Console.ReadLine().Split().ToArray();
            while (line.Count() > 1 && line.Count() <= 3)
            {
                if (line.Count() == 2)
                    robots.Add(new Robot(line[0], line[1]));
                else if (line.Count() == 3)
                    citizens.Add(new Citizen(line[0], int.Parse(line[1]), line[2]));
                else if (line[0] == "End")
                    break;
                else
                    throw new InvalidOperationException("Incorrect words count or final word!!!");

                line = Console.ReadLine().Split().ToArray();
            }
                    
            string searching = Console.ReadLine();
            Console.WriteLine(string.Join("\n", 
                robots.Select(x => x.ID)
                      .ToArray()
                      .Where(x => x.Substring(x.Length-3, 3) == searching)
                      .ToArray()));
            Console.WriteLine(string.Join("\n", 
                citizens.Select(x => x.ID)
                        .ToArray()
                        .Where(x => x.Substring(x.Length-3, 3) == searching)
                        .ToArray()));

            Console.ReadKey();
        }
    }
}
/*
 * 
Pesho 22 9010101122
MK‐13 558833251
MK‐12 33283122
End
122

Toncho 31 7801211340
Penka 29 8007181534
IV‐22 8999999
Stamat 54 3401018380
KKK‐666 80808080
End
340
 */
