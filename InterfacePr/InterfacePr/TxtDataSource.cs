using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace InterfacePr
{
    class TxtDataSource:IDataSource
    {
        private static string Path { get; set; }
        private string[] _lines;

        private Student[] _students = new Student[100];
        private int _studentsQuant;
        public Group[] Groups = new Group[100];
        private int _groupsQuant;
        int _groupId;
        private string _description;
        int _studentId;
        int _studentGroupId;
        private string _name;
        int _enrollYear;

        private int _groupCounter;
        private int _studentCounter;
        string _studentChecker = "students";
        string group_checker = "groups";

        private const string Regex1 = @"[0-9]{1,2}";
        private const string Regex2 = @"[0-9]{1,2};\w{7,7};$";
        private const string Regex3 = @"[0-9]{1,2};[0-9]{1,2};\w{2,20};[0-9]{4,4}";


        public TxtDataSource(string path)
        {
            //добавить  проверку
            Path = path;
        }

        public void Open()
        {
            if (!File.Exists(Path))
                throw new FileNotFoundException();
            _lines = System.IO.File.ReadAllLines(Path);

        }

        public void Load()
        {


            //Проверка первой строки
            var lines0 = _lines[0].Substring(0, 6);


            if (String.Compare(lines0, group_checker)!=0)
            {
                throw new Exception("Ошибка в первой строке - groups");
            }

            lines0 = _lines[0].Substring(_lines[0].LastIndexOf("[") + 1);
            lines0 = lines0.Remove(lines0.IndexOf("]"));

            if (!Regex.IsMatch(lines0, Regex1))
                throw new Exception("Ошибка в первой строке. Count");

            _groupCounter = int.Parse(lines0);

            var lines1 = _lines[_groupCounter + 1].Substring(0, 8);

            if (String.Compare(lines1, _studentChecker) != 0)
            {
                throw new Exception("Ошибка в строке student[count]");
            }

            lines1 = _lines[_groupCounter + 1].Substring(_lines[_groupCounter + 1].LastIndexOf("[") + 1);
            lines1 = lines1.Remove(lines1.IndexOf("]"));

            if (!Regex.IsMatch(lines1, Regex1))
                throw new Exception("Ошибка в первой строке. Count");

            _studentCounter = int.Parse(lines1);

        }

        public void Parse()
        {
            for (var i = 1; i < _groupCounter + 1; i++)
                if (Regex.IsMatch(_lines[i], Regex2))
                {
                    Groups[_groupsQuant] = new Group(int.Parse(_lines[i].Remove(_lines[i].IndexOf(";"))),
                        (_lines[i].Substring(_lines[i].IndexOf(";") + 1)).Remove(
                            (_lines[i].Substring(_lines[i].IndexOf(";") + 1)).IndexOf(";")));
                    _groupsQuant++;
                }

            for (var i = (_groupCounter + 2); i < (_groupCounter + 2 + _studentCounter); i++)
            {
                if (!Regex.IsMatch(_lines[i], Regex3)) continue;
                var kusok0 = _lines[i].Remove(_lines[i].IndexOf(";"));
                var kusok1 = _lines[i].Remove(_lines[i].LastIndexOf(";"));
                var kusok2 = kusok1.Remove(kusok1.LastIndexOf(";"));
                var kusok3 = kusok2.Remove(0, kusok0.Length + 1);
                var kusok4 = kusok1.Remove(0, kusok2.Length + 1);
                var kusok5 = _lines[i].Remove(0, kusok1.Length + 1);


                _studentId = int.Parse(kusok0);
                _studentGroupId = int.Parse(kusok3);
                _name = kusok4;
                _enrollYear = int.Parse(kusok5);

                _students[_studentsQuant] = new Student(_studentId, _studentGroupId, _name, _enrollYear);
                _studentsQuant++;
            }
        }

        public void GetData()
        {
            Console.Clear();
            Console.WriteLine("{0,23}", "ГРУППЫ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("{0,5}{1,15}{2,20}", "#", "Номер группы", "Описание");
            Console.WriteLine("----------------------------------------");
            for (var i = 0; i < _groupsQuant; i++)
                Console.WriteLine("{0,5}{1,15}{2,20}", i, Groups[i].Id, Groups[i].Description);
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("{0,30}", "СТУДЕНТЫ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("{0,5}{1,5}{2,15}{3,15}{4,15}", "#", "Id", "Номер группы", "Фамилия", "Год выпуска");
            Console.WriteLine("-------------------------------------------------------");
            for (var i = 0; i < _studentsQuant; i++)
                Console.WriteLine("{0,5}{1,5}{2,15}{3,15}{4,15}", i, _students[i].Id, _students[i].GroupId, _students[i].Name,
                    _students[i].EnrollYear);
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine();
        }

        public void Close(string answer)
        {
            if (answer == "Y")
                Process.GetCurrentProcess().Kill();
        }
    }
}
