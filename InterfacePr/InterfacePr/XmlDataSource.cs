using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Xml.Schema;
using System.Diagnostics;

namespace InterfacePr
{
    class XmlDataSource:IDataSource
    {
        private string Path { get; set; }
        
        public Student[] Students = new Student[100];
        public int students_quant = new int();
        public Group[] Groups = new Group[100];
        public int groups_quant = new int();

        int group_id = new int();
        private string description = null;

        int student_id = new int();
        int student_group_id = new int();
        private string name = null;
        int enroll_year = new int();

        public XDocument XDoc = new XDocument();

        public XmlDataSource(string path)
        {
            Path = path;
            XDoc = XDocument.Load(@Path);
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
            Console.WriteLine("Использование Load");
            Console.WriteLine("---------------------");
            string xsdMarkup =
                @"<xs:schema attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""db"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""groups"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""group"" maxOccurs=""unbounded"" minOccurs=""0"">
                <xs:complexType>
                  <xs:simpleContent>
                    <xs:extension base=""xs:string"">
                      <xs:attribute type=""xs:byte"" name=""id"" use=""optional""/>
                      <xs:attribute type=""xs:string"" name=""description"" use=""optional""/>
                    </xs:extension>
                  </xs:simpleContent>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""students"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""student"" maxOccurs=""unbounded"" minOccurs=""0"">
                <xs:complexType>
                  <xs:simpleContent>
                    <xs:extension base=""xs:string"">
                      <xs:attribute type=""xs:byte"" name=""id"" use=""optional""/>
                      <xs:attribute type=""xs:byte"" name=""groupid"" use=""optional""/>
                      <xs:attribute type=""xs:string"" name=""name"" use=""optional""/>
                      <xs:attribute type=""xs:short"" name=""year"" use=""optional""/>
                    </xs:extension>
                  </xs:simpleContent>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
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
            Console.WriteLine(errors ? "Документ не прошёл проверку" : "Документ прошёл проверку");
            Console.WriteLine("---------------------");
        }

        public void Parse()
        {
            Console.WriteLine("Парсинг");
            Console.WriteLine("---------------------");
            foreach (var xElement in XDoc.Descendants("group").Where(xElement => xElement.HasAttributes))
            {
                if (xElement.Attribute("id") != null)
                {
                    group_id = int.Parse(xElement.Attribute("id").Value);
                }

                if (xElement.Attribute("description") != null)
                {
                    description = xElement.Attribute("description").Value;

                }
                Groups[groups_quant] = new Group(group_id,description);
                groups_quant++;
            }
            foreach (XElement xElement in XDoc.Descendants("student").Where(xElement => xElement.HasAttributes))
            {
                if (xElement.Attribute("id") != null)
                {
                    student_id = int.Parse(xElement.Attribute("id").Value);
                }
                if (xElement.Attribute("groupid") != null)
                {
                    student_group_id = int.Parse(xElement.Attribute("groupid").Value);
                }
                if (xElement.Attribute("name") != null)
                {
                    name = xElement.Attribute("name").Value;
                }
                if (xElement.Attribute("year") != null)
                {
                    enroll_year = int.Parse(xElement.Attribute("year").Value);
                }
                Students[students_quant] = new Student(student_id, student_group_id, name, enroll_year);
                students_quant++;
            }
        }

        public void GetData()
        {
            Console.Clear();
            Console.WriteLine("{0,23}","ГРУППЫ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("{0,5}{1,15}{2,20}","#","Номер группы","Описание");
            Console.WriteLine("----------------------------------------");
            for (var i=0;i<groups_quant;i++)
                Console.WriteLine("{0,5}{1,15}{2,20}", i, Groups[i].Id, Groups[i].Description);
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("{0,30}","СТУДЕНТЫ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("{0,5}{1,5}{2,15}{3,15}{4,15}","#","Id","Номер группы","Фамилия","Год выпуска");
            Console.WriteLine("-------------------------------------------------------");
            for (var i=0;i<students_quant;i++)
                Console.WriteLine("{0,5}{1,5}{2,15}{3,15}{4,15}", i, Students[i].Id, Students[i].GroupId, Students[i].Name,
                    Students[i].EnrollYear);
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

        }

        public void Close(string answer)
        {
            if (answer=="Y")
                Process.GetCurrentProcess().Kill();
        }

    }
}
