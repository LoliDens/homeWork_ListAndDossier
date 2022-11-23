using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_ListAndDossier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAddDosseir = "1";
            const string CommandShowDosseirs = "2";
            const string CommandDeleteDossier = "3";
            const string CommandExit = "4";

            List<string> fullNames = new List<string>(3) {"Булыги Олег Дмитриевич","Фазлетдинов Данил Саловатович","созонов Алексей Дмитреивич" };
            List<string> positions = new List<string>(3) {"Менеджер","Программист","Дизайнер" };
            bool isExit = false;

            while (isExit == false) 
            {
                Console.WriteLine($"Нажминте " +
                    $"\n{CommandAddDosseir} - для того чтобы добавить человека в список" +
                    $"\n{CommandShowDosseirs} - для того чтобы вывести список ФИО и дожностей" +
                    $"\n{CommandDeleteDossier} - удалить человека из списка по ФИО"+
                    $"\n{CommandExit} - чтобы выйти из программы.");
                string userInput = Console.ReadLine();

                switch (userInput) 
                {
                    case CommandShowDosseirs:
                        ShowDossiers(fullNames, positions);
                        break;

                    case CommandAddDosseir:
                        AddDossier(fullNames, positions);
                        break;

                    case CommandDeleteDossier:
                        DeleteDossier(fullNames, positions);
                        break;

                    case CommandExit:
                        isExit = true;
                        break;

                    default:
                        Console.WriteLine("Комманда нераспознанна");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
            

        }

        static void ShowDossiers(List<string> fullNames, List<string> positions)
        {
            for (int i = 0; i < fullNames.Count; i++) 
            {
                Console.WriteLine($"{i+1}. {fullNames[i]} - {positions[i]}");
            }
        }

        static void AddDossier(List<string> fullNames, List<string> positions) 
        {
            string userInput;

            Console.Write("Введите ФИО: ");
            userInput = Console.ReadLine();
            fullNames.Add(userInput);

            Console.Write("Введите должносить: ");
            userInput = Console.ReadLine();
            positions.Add(userInput);
        }

        static void DeleteDossier(List<string> fullNames, List<string> positions) 
        {
            Console.WriteLine("Введите номер досье которое хотите удалить: ");
            int numberDossier = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{fullNames[numberDossier - 1]} - был удален.");
            fullNames.RemoveAt(numberDossier - 1);
            positions.RemoveAt(numberDossier - 1);
        }


    }
}
