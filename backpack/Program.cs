using System;
using System.Collections.Generic;

namespace backpack
{/* Пользователь должен, введя число 1, иметь возможность добавлять предметы в рюкзак, например, яблоко.
Пользователь также должен иметь возможность распечатать все содержимое рюкзака, если он введет номер 2.
Пользователь должен иметь возможность очистить все содержимое рюкзака, введя число 3.
Программа должна быть прекращена, если пользователь вводит номер 4.
Если вы не хотите использовать списки для решения задачи, вы можете сохранить содержимое рюкзака в строковую переменную.
Программа завершится, когда ключевое слово return будет достигнуто в методе Main.
Рюкзак - часть 2
Как только вы заставите часть 1 работать, вы должны продолжить развивать свой рюкзак.
Теперь в рюкзаке должно поместиться только 6 предметов, если пользователь пытается добавить дополнительные предметы, должно появиться сообщение об ошибке.
Должна быть возможность вынуть только самый последний предмет из рюкзака.
*/
    class Program
    {
        static List<string> backpack = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 - add");
                Console.WriteLine("2 - print");
                Console.WriteLine("3 - clear");
                Console.WriteLine("4 - remove");
                Console.WriteLine("5 - exit");
                Console.WriteLine("There are " + backpack.Count + " things ");

                string cmd = Console.ReadLine();

                switch (cmd)

                {
                    case "1":
                        
                        if(backpack.Count == 6 ){
                            Console.WriteLine("Backpack is full");
                            break;
                        }
                        Console.WriteLine(" enter the thing name");
                        string thing = Console.ReadLine();
                        backpack.Add(thing);
                        break;

                    case "2":
                        foreach (string t in backpack)
                        {
                            Console.WriteLine(t);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Cleaning the backpack");
                        backpack.Clear();
                        break;
                    case "4":
                       backpack.RemoveAt(backpack.Count - 1);
                        break;
                    case "5":
                        Console.WriteLine("Exit the backpack");
                       Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("I do not understand");
                        break;

                }

            }
        }
    }
}
