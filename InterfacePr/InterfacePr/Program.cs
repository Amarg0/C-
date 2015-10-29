using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InterfacePr
{
    internal delegate void Loader();
    class Program
    {
        
        public static void Menu()
        {
            Console.WriteLine("1. Загрузить источник данных");
            Console.WriteLine("0. Выход");
        }

        public static string getFileExtension(string fileName)
        {
            return fileName.Substring(fileName.LastIndexOf(".") + 1);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Program.Menu();

                    var choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            //Console.WriteLine("Введите путь к файлу:");
                            //var path = Console.ReadLine();

                            var path = "C:\\Users\\Amarg0\\Desktop\\TXTFile1.txt";
                            if (getFileExtension(path) == "xml")
                            {
                                Console.WriteLine("XML");
                                var xmlData = new XmlDataSource(path);
                                Loader xmlLoader = xmlData.Open;
                                xmlLoader += xmlData.Load;
                                xmlLoader += xmlData.Parse;
                                xmlLoader += xmlData.GetData;
                                try
                                {
                                    xmlLoader();
                                }
                                catch (FileNotFoundException)
                                {
                                    
                                    Console.WriteLine("Файл не найден");
                                }
                                Console.WriteLine("Выйти Y/N?");
                                xmlData.Close(Console.ReadLine());
                            }
                            else
                            {
                                if (getFileExtension(path) == "mdb")
                                {
                                    Console.WriteLine("SQL");
                                    var sqlData = new  SqlDataSource(path);
                                    Loader sqlLoader = sqlData.Open;
                                    sqlLoader += sqlData.Load;
                                    sqlLoader += sqlData.Parse;
                                    sqlLoader += sqlData.GetData;
                                    try
                                    {
                                        sqlLoader();
                                    }
                                    catch (FileNotFoundException)
                                    {

                                        Console.WriteLine("Файл не найден");
                                    }
                                }
                                else
                                {
                                    if (getFileExtension(path) == "txt")
                                    {
                                        Console.WriteLine("TXT");
                                        var txtData = new TxtDataSource(path);
                                        Loader txtLoader = txtData.Open;
                                        txtLoader += txtData.Load;
                                        txtLoader += txtData.Parse;
                                        txtLoader += txtData.GetData;
                                        try
                                        {
                                            txtLoader();
                                        }
                                        catch (FileNotFoundException)
                                        {

                                            Console.WriteLine("Файл не найден");
                                        }
                                        Console.WriteLine("Выйти Y/N?");
                                        txtData.Close(Console.ReadLine());
                                    }
                                }
                            }
                            break;
                        default:
                            break;

                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка ввода");
                    Console.WriteLine();
                    Console.WriteLine("<--------- ENTER");
                    Console.ReadLine();
                }
            }
        }
    }
}
