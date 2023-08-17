using System;

namespace Домашняя_работа_8_задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Заполнение телефонной книги
            /// </summary>
            /// <param name="newMember"></param>
            /// <returns></returns>
            static Dictionary<int, string> FillingPhoneBook(Dictionary<int, string> newMember)
            {
                do
                {
                    Console.WriteLine("Введите номер телефона без знаков препинания.");
                    string enterNumber = Console.ReadLine();
                    int phoneNumber;
                    if (enterNumber == "")
                    {
                        break;
                    }
                    else
                    {
                        phoneNumber = int.Parse(enterNumber);
                    }
                    Console.WriteLine("Введите фио владельца номера.");
                    string phoneOwner = Console.ReadLine();
                    newMember.Add(phoneNumber, phoneOwner);
                } while (true);
                return newMember;
            }

            /// <summary>
            /// Показ телефонной книги
            /// </summary>
            /// <param name="phoneBook"></param>
            static void ShowTheList(Dictionary<int, string> phoneBook)
            {
                foreach (var item in phoneBook)
                {
                    Console.WriteLine(item);
                }
            }

            /// <summary>
            /// Метод по поиску нужного значения по ключу
            /// </summary>
            /// <param name="phoneBook"></param>
            static void FindValue(Dictionary<int, string> phoneBook)
            {
                Console.WriteLine("Введите номер телефона для поиска.");
                int phoneForCatch = int.Parse(Console.ReadLine());
                string value = "";
                if (phoneBook.TryGetValue(phoneForCatch, out value))
                {
                    Console.WriteLine(value);
                }
                else
                {
                    Console.WriteLine("Такого номера в списке нет");
                }
            }

            static void Main(string[] args)
            {
                Dictionary<int, string> phoneBook = new Dictionary<int, string>();
                Console.WriteLine("Добро пожаловать в телефонную книгу.");

                phoneBook = FillingPhoneBook(phoneBook);
                //ShowTheList(phoneBook);
                FindValue(phoneBook);

            }
        }
    }
}
