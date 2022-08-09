using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesList
{
    class Program
    {
        struct Human
        {
            public string Name;
            public int Age;
        }
        Program(Human[] human)
        {
            human[0].Name = "Федя";
            human[0].Age = 24;
            human[1].Name = "Ержан";
            human[1].Age = 12;
            human[2].Name = "Феофан";
            human[2].Age = 45;
            human[3].Name = "Вальдемар";
            human[3].Age = 46;
            human[4].Name = "Миролюб";
            human[4].Age = 99;
            human[5].Name = "Светозар";
            human[5].Age = 18;
            human[6].Name = "Жорж";
            human[6].Age = 55;
            human[7].Name = "Гаврила";
            human[7].Age = 12;
            human[8].Name = "Герасим";
            human[8].Age = 37;
            human[9].Name = "Светозар";
            human[9].Age = 85;
            human[10].Name = "Джесси Пинкман";
            human[10].Age = 17;
        }
        static void ReplaceElement(Human[] human, int _number, string _item, int _item2)
        {
            human[_number].Name = _item;
            human[_number].Age = _item2;
        }
        static void PrintArray(Human[] human)
        {
            for(int i = 0; i < human.Length; i++)
            {
                Console.WriteLine("{0}) {1}, возраст {2}", i + 1, human[i].Name, human[i].Age);
            }
            Console.WriteLine();
        }
        static void GuestSearch(Human[] human)
        {
            PrintArray(human);
            Console.WriteLine("Для поиска введите имя гостя:");
            string match = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < human.Length; i++)
            {
                if (human[i].Name == match)
                {
                    count++;
                    Console.WriteLine("Имя {0} входит в список гостей, его возраст {1}, " +
                        "номер в списке {2}", match, human[i].Age, i + 1);
                }     
             }
            if (count == 0)
            {
                Console.WriteLine("Имя {0} осутствует в списке гостей!", match);
            }
        }
        static void ReplaceGuest(Human[] human)
        {
            Console.WriteLine("Хотите ли вы заменить имя в списке гостей? 1 - да, 2 - нет (завершить работу программы).");
            string check = "";
            do
            {
                check = Console.ReadLine();
                if (check == "1")
                {
                    do
                    {
                        Console.WriteLine("Имя под каким номером хотите заменить?");
                        int numExchange = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите имя нового гостя:");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Введите возраст нового гостя:");
                        int newAge = Convert.ToInt32(Console.ReadLine());
                        ReplaceElement(human, numExchange - 1, newName, newAge);
                        PrintArray(human);
                        Console.WriteLine("Хотите продолжить? 1 - да, 2 - нет (завершить работу программы).");
                        check = Console.ReadLine();
                    } while (check == "1");
                }
                else
                {
                    if (check == "2")
                    {
                        Console.WriteLine("Завершение работы программы.");
                    }
                    else
                    {
                        Console.WriteLine("Такого варианта нет.\nПопробуйте ещё раз:");
                    }
                }
            } while (check != "2");
        }
        static void Main(string[] args)
        {
            Human[] human = new Human[11];
            Program program = new Program(human);
            GuestSearch(human);
            ReplaceGuest(human);
        }
    }
}
