using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace thirdtry
{
    class Start
    {
        public void Welcome()
        {
            Console.WriteLine("1. Создать запись");
            Console.WriteLine("2. Удалить запись");
            Console.WriteLine("3. Изменить запись");
            Console.WriteLine("4. Вывести запись");
            Console.WriteLine("5. Вывести все записи");
            Console.WriteLine("6. Инд. задание");
            Console.WriteLine("7. Закрыть программу");
        }

        public void Starter(Database database)
        {
            int key = new int();
            string name = null;
            int price = new int();
            int censure = new int();
            bool fl = new bool();
            BussinessLayer bussiness = new BussinessLayer();
            int choice = new int();

                while (true)
                {
                    try
                    {
                        Console.Clear();
                    Welcome();
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Введите наз-е игрушки:");
                            name = Console.ReadLine();
                            Console.WriteLine("Введите цену игрушки:");
                            price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите рек. возраст ребёнка:");
                            censure = int.Parse(Console.ReadLine());
                            bussiness.Create(database, name, price, censure);
                            Console.WriteLine();
                            Console.WriteLine("<------ ENTER");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Введите ключ удаляемой игрушки:");
                            key = int.Parse(Console.ReadLine());
                            fl = false;
                            fl = bussiness.delete(database, key, fl);
                            if (fl)
                                Console.WriteLine("Запись успешно удалена!");
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Запись не найдена!");
                            }
                            Console.WriteLine();
                            Console.WriteLine("<------ ENTER");
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Введите ключ изменяемой записи:");
                            key = int.Parse(Console.ReadLine());
                            fl = false;
                            fl = bussiness.Check(database, key, fl);
                            if (fl)
                            {
                                Console.WriteLine("Запись найдена.");
                                Console.WriteLine("Введите новое название игрушки:");
                                name = Console.ReadLine();
                                Console.WriteLine("Введите новую цену игрушки:");
                                price = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите новый рек. возраст:");
                                censure = int.Parse(Console.ReadLine());
                                bussiness.Change(database, key, name, price, censure);
                                Console.WriteLine("Изменение данных завершено!");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Запись с данным ключом не найдена!");
                            }
                            Console.WriteLine();
                            Console.WriteLine("<------ ENTER");
                            Console.ReadLine();
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("Введите ключ записи");
                            key = int.Parse(Console.ReadLine());
                            toy finded_toy = new toy();
                            finded_toy = bussiness.Find(database, key);
                            Console.Clear();
                            if (finded_toy != null)
                            {
                                Console.WriteLine("------------------------------------------------------------------");
                                Console.WriteLine(String.Format("{0,14}{1,20}{2,20}{3,12}\n", "Ключ", "Наименование", "Стоимость",
                                "Рек.возраст"));
                                Console.WriteLine(String.Format("{0,14}{1,20}{2,20}{3,12}\n", finded_toy.Key, finded_toy.Name, finded_toy.Price,
                                finded_toy.Censure));
                                Console.WriteLine("------------------------------------------------------------------");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Игрушка с данным ключом не найдена!");
                            }
                            Console.WriteLine();
                            Console.WriteLine("<------ ENTER");
                            Console.ReadLine();
                            break;
                        case 5:
                            Console.Clear();
                            bussiness.Readall(database);
                            Console.WriteLine("База данных игрушек:");
                            Console.WriteLine("------------------------------------------------------------------");
                            Console.WriteLine(String.Format("{0,14}{1,20}{2,20}{3,12}\n", "Ключ", "Наименование", "Стоимость",
                                "Рек.возраст"));
                            for (int i = 0; i < 100; i++)
                                if (database.toys[i] != null)
                                    Console.WriteLine(String.Format("{0,14}{1,20}{2,20}{3,12}\n", database.toys[i].Key, database.toys[i].Name,
                                        database.toys[i].Price, database.toys[i].Censure));
                            Console.WriteLine("------------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("<------ ENTER");
                            Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Выборка игрушек, не превышающих указанную цену и подходящая детям указанного возраста:");
                            Console.WriteLine("Введите цену:");
                            price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите  возраст ребёнка:");
                            censure = int.Parse(Console.ReadLine());
                            database = bussiness.choose(database, price, censure);
                            Console.WriteLine("База данных игрушек:");
                            Console.WriteLine("------------------------------------------------------------------");
                            Console.WriteLine(String.Format("{0,14}{1,20}{2,20}{3,12}\n", "Ключ", "Наименование", "Стоимость",
                                "Рек.возраст"));
                            for (int i = 0; i < 100; i++)
                                if (database.toys[i] != null)
                                    Console.WriteLine(String.Format("{0,14}{1,20}{2,20}{3,12}\n", database.toys[i].Key, database.toys[i].Name,
                                    database.toys[i].Price, database.toys[i].Censure));
                            Console.WriteLine("------------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("<------ ENTER");
                            Console.ReadLine();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("Выйти из программы? (Y/N)");
                            name = Console.ReadLine();
                            if (name == "Y")
                                Process.GetCurrentProcess().Kill();
                            break;
                    }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Ошибка ввода!");
                        Console.WriteLine();
                        Console.WriteLine("<------ ENTER");
                        Console.ReadLine();
                        
                    }

                }
            }
        }
    }