using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Напишете скрипт който да изпълнява следните команди:
● Създайте две директории с име documents и games.
● Създайте нов файл с име students.txt.
● Към файла students.txt добавете текст 42.
● Преместете файла в директорията games.

    Всяка команда да бъде на нов ред.
Фрагмент:
Script

!#/bin/bash
cd documents
mkdir games
touch students.txt
echo 42 > students.txt
move students.txt games 
     
mkdir documents
mkdir games
touch students.txt
echo 42 > students.txt
mv students.txt games

//при DOS:
md documents
md games
copy con students.txt
echo 42 ^Z
move students.txt games  
     
*/
namespace Tema12_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
