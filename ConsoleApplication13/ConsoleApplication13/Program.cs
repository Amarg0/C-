//Программа запускается на консоли и показывает в левом верхнем углу консоли
//С точнотью до секунд. Также текущее время постоянно записывается в файл (он содержит одну строку
//временем.

//В программу добавить меню: 1 - добавить будильник, 2 - удалить будильник.

//При нажатии на 1 пользователю позволяется добавить будильник с точностью до минуты
//с выбранным текстом.

//При нажатии на 2 - пользователю дается возможность удалить какой-либо будильник.

//При срабатывании будильника, проиграть звук и отобразить текст, связанный с будильником.

//Дополнительно создать файл с именем, равным идентификатору будильника
//Записать в него время срабатывания и текст, связанный с этим будильником.

//В программе предусмотреть два делегата: секундный и минутный.

//Отсчет времени производится в отдельном потоке. Класс Thread


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime;
using System.IO;
using System.Diagnostics;
using System.Media;

namespace Будильник
{
    delegate int MinuteDelegate(DateTime ringring);
    delegate int SecondDelegate(DateTime ringring);

    public class WakeUPP
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public string Messager { get; set; }
        public WakeUPP (int hour = 25, int minute = 61, string messager = null)
        {
            Hour = hour;
            Minute = minute;
            Messager = messager;
        }
    }
    public class Program
    {
        
        
        static int GetMinute (DateTime ring)
        {
            return ring.Minute;
        }

        static int GetSecond (DateTime ring)
        {
            return ring.Second;
        }
        static void Main()
        {
            WakeUPP[] MyWakeUPP= new WakeUPP[100];
            Program lol = new Program();

            Thread time_thread = new Thread(new ParameterizedThreadStart(GetCurrentTime));
            time_thread.Start(MyWakeUPP);
            Console.ReadKey();

            int timers_size = new int();
            int choice = new int();
            int hour = new int();
            int minute = new int();
            int rubb = new int();
            string wake_text = null;
            

                while (true)
                {
                    welcome();
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Введите час:");
                            hour = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите минуту:");
                            minute = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите текст будильника:");
                            wake_text = Console.ReadLine();
                            MyWakeUPP[timers_size]=new WakeUPP(hour, minute, wake_text);
                            timers_size++;
                            break;
                        case 2:
                            Console.WriteLine("Введите номер будильника, который необходимо удалить.");
                            rubb=int.Parse(Console.ReadLine());
                            MyWakeUPP[rubb] = null;
                            break;
                        case 0:
                            time_thread.Abort();
                            Process.GetCurrentProcess().Kill();
                            break;
                        default:
                            break;

                    }

                }
            
        }

        public static void GetCurrentTime(object a)
        {
                WakeUPP[] massiv = (WakeUPP[])a;
                SoundPlayer sp = new SoundPlayer("C:\\Users\\Amargo\\Desktop\\Alarm01.wav");
                SecondDelegate sc = new SecondDelegate(GetSecond);
                MinuteDelegate mn = new MinuteDelegate(GetMinute);
                
                Console.WriteLine(DateTime.Now);
                while (true)
                {
                    DateTime NowTime = DateTime.Now;

                    for (int i = 0; i < 100; i++)
                        if (massiv[i]!= null)
                            if (massiv[i].Hour == NowTime.Hour && massiv[i].Minute == NowTime.Minute)
                            {

                                sp.Play();
                                Console.WriteLine(massiv[i].Messager);
                                string file_adress = "c:\\Users\\Amargo\\Desktop\\101\\" + "Будильник_"
                                +i+".txt";
                                FileStream nowtimefile = new FileStream(file_adress,
                                       FileMode.Create);
                                StreamWriter writer1 = new StreamWriter(nowtimefile);
                                writer1.WriteLine("Будильник сработал в " + NowTime.Hour + " часов " + mn(NowTime) +
                                    " минут " + sc(NowTime) + " секунд") ;
                                writer1.WriteLine("Текст будильника: " + massiv[i].Messager);
                                writer1.Close();
                                Thread.Sleep(50000);
                                sp.Stop();
                            }
                    FileStream nowtimefile1 = new FileStream("c:\\Users\\Amargo\\Desktop\\101\\nowtime.txt",
                               FileMode.Create);
                    NowTime = DateTime.Now;
                    StreamWriter writer = new StreamWriter(nowtimefile1);
                    writer.Write("{0}", NowTime);
                    writer.Close();
                    Thread.Sleep(1000);
                }
        }

        public static void welcome()
        {
            Console.WriteLine();
            Console.WriteLine("1. Добавить будильник");
            Console.WriteLine("2. Удалить будильник");
            Console.WriteLine("0. Закрыть программу");
        }
    }
}