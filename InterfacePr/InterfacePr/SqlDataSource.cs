using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace InterfacePr
{
    class SqlDataSource:IDataSource
    {
        private string Path { get; set; }

        private readonly Student[] _students = new Student[100];
        private int _studentsQuant;
        public Group[] Groups = new Group[100];
        private int _groupsQuant;

        int _groupId;
        private string _description;

        int _studentId;
        int _studentGroupId;
        private string _name;
        int _enrollYear;

        public XDocument XDoc = new XDocument();

        public SqlDataSource(string path)
        {
            Path = path;
        }

        public void Open()
        {
            Console.WriteLine("Использование Open");
            Console.WriteLine("---------------------");
            if (!File.Exists(Path))
                throw new FileNotFoundException();
        }

        public void Load()
        {
            Console.WriteLine(Path);
            var connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Path;
            OleDbConnection myConnection = new OleDbConnection(connStr);
            try
            {
                myConnection.Open();
            }
            catch (OleDbException seDbException)
            {
                
                Console.WriteLine("Ошибка подключения:{0}",seDbException.Message);
            }
            Console.WriteLine("Соединение успешно установлено");
            var dset = new DataSet("db");
            using (var myAdapter = new OleDbDataAdapter())
            {
                var studCommand = new OleDbCommand("SELECT * FROM Students",myConnection);
                var groupCommand = new OleDbCommand("SELECT * FROM Groups",myConnection);
                myAdapter.SelectCommand = studCommand;
                myAdapter.Fill(dset, "Students");
                myAdapter.SelectCommand = groupCommand;
                myAdapter.Fill(dset, "Groups");

            }
            
            //Console.WriteLine(dset.GetXml());
            //FileStream sqlxml=new FileStream("c:\\users\\amarg0\\desktop\\sqlxml.txt",FileMode.Create);
            //StreamWriter writer = new StreamWriter(sqlxml);
            //writer.Write(dset.GetXmlSchema());
            //writer.Close();
            XDoc = XDocument.Parse(dset.GetXml());
            const string xsdMarkup = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema id=""db"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
  <xs:element name=""db"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element name=""Students"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""id"" type=""xs:int"" minOccurs=""0"" />
              <xs:element name=""group_id"" type=""xs:string"" minOccurs=""0"" />
              <xs:element name=""stud_name"" type=""xs:string"" minOccurs=""0"" />
              <xs:element name=""enroll_year"" type=""xs:int"" minOccurs=""0"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Groups"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""id"" type=""xs:int"" minOccurs=""0"" />
              <xs:element name=""Description"" type=""xs:string"" minOccurs=""0"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:choice>
    </xs:complexType>
  </xs:element>
</xs:schema>";
            var xmlSchemaSet = new XmlSchemaSet();
            xmlSchemaSet.Add("", XmlReader.Create(new StringReader(xsdMarkup)));
            var errors = false;
            XDoc.Validate(xmlSchemaSet, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });
            if (errors)
                throw new XmlSchemaException("Документ не прошёл проверку по схеме");
        }

        public void Parse()
        {
            foreach (var xElement in  XDoc.Descendants("db").Descendants("Groups"))
            {
                    foreach (var xxElement in xElement.Descendants("id"))
                    {
                        _groupId = int.Parse(xxElement.Value);
                    }

                    foreach (var xxElement in xElement.Descendants("Description"))
                    {
                        _description = xxElement.Value;
                    }

                    Groups[_groupsQuant] = new Group(_groupId, _description);
                    _groupsQuant++;
            }

            foreach (var xElement in XDoc.Descendants("db").Descendants("Students"))
            {
                foreach (var xxElement in xElement.Descendants("id"))
                {
                    _studentId = int.Parse(xxElement.Value);
                }

                foreach (var xxElement in xElement.Descendants("group_id"))
                {
                    _studentGroupId = int.Parse(xxElement.Value);
                }
                foreach (var xxElement in xElement.Descendants("stud_name"))
                {
                    _name = xxElement.Value;
                }

                foreach (var xxElement in xElement.Descendants("enroll_year"))
                {
                    _enrollYear = int.Parse(xxElement.Value);
                }
                _students[_studentsQuant]=new Student(_studentId,_studentGroupId,_name,_enrollYear);
                _studentsQuant++;
            }

            Console.ReadKey();
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
            Console.ReadKey();
        }

        public void Close(string answer)
        {
            if (answer == "Y")
                Process.GetCurrentProcess().Kill();
        }
    }
}
