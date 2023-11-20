using System.Xml.Linq;

namespace Lab2
{
    class LINQParsingStrategy : IXmlParserStrategy
    {
        List<Student> info = new List<Student>();
        XDocument doc = new XDocument();

        public List<Student> Analyze(Student student, string path)
        {
            doc = XDocument.Load(path);
            List<XElement> match = (from val in doc.Descendants("student")
                                    let grade = int.Parse(val.Attribute("grade").Value)
                                    where
                                    (
                                        (student.Faculty == null || student.Faculty == val.Parent.Parent.Parent.Attribute("name").Value) &&
                                        (student.Department == null || student.Department == val.Parent.Parent.Attribute("name").Value) &&
                                        (student.Discipline == null || student.Discipline == val.Parent.Attribute("name").Value) &&
                                        (student.Name == null || student.Name == val.Attribute("name").Value) &&
                                        (student.Grade == null || student.Grade == val.Attribute("grade").Value) &&
                                        (student.MinGrade == -1 || grade >= student.MinGrade) &&
                                        (student.MaxGrade == 101 || grade <= student.MaxGrade)
                                    )
                                    select val).ToList();

            foreach (XElement obj in match)
            {
                Student stud = new Student();
                stud.Faculty = obj.Parent.Parent.Parent.Attribute("name").Value;
                stud.Department = obj.Parent.Parent.Attribute("name").Value;
                stud.Discipline = obj.Parent.Attribute("name").Value;
                stud.Name = obj.Attribute("name").Value;
                stud.Grade = obj.Attribute("grade").Value;
                info.Add(stud);
            }

            return info;
        }

    }
}
