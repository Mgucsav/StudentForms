using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace StudentForms
{
    class Students
    {
        public List<Student> students { get; set; }

        public Students()
        {
            students = new List<Student>();
        }

        public DataSet makeDBOperations(string query)
        {
            DataSet dataSet = null;
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ders\Desktop\StudentForms\StudentForms\DatabaseStd.mdf;Integrated Security=True");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                
                connection.Open();

                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Table");
                connection.Close();
            }
            catch(Exception ex)
            {
                dataSet = null;
            }

            return dataSet;
        }
        public bool addStudent(Student std)
        {

            DataSet ds = makeDBOperations("insert into StudentTable(Number, Name, BirthDate, Gender) values('"+ std.Number +"', '" + std.Name + "', '" + std.BirthDate + "', '" + std.Gender + "')");
            
            if(ds != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool deleteStudent(string number)
        {
            DataSet ds = makeDBOperations("delete from StudentTable where Number = '" + number + "'");

            if (ds != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool addLessonToStudent(string lesson, string number)
        {

            DataSet ds = makeDBOperations("insert into StudentLessonTable(Number, Code_) values('" + number + "', '" + lesson + "')");

            if (ds != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteLessonFromStudent(string number, string lesson)
        {
            DataSet ds = makeDBOperations("delete from StudentLessonTable where Number = '" + number + "' and Code_ ='" + lesson + "'");
            if (ds != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet listLessonsOfStudents(string number)
        {
            return makeDBOperations("select Code_, Name, AKTS, Credit from SLView where Number = '" + number + "'");
        }
        public DataSet getAllStudentNumber()
        {
            return makeDBOperations("select Number from StudentTable");
        }

        public DataSet getAllStudents()
        {
            return makeDBOperations("select * from StudentTable");
        }

        public bool updateStudent(string name, string number, DateTime birthDate)
        {
            DataSet ds = makeDBOperations("update StudentTable set Name = '" + name + "', BirthDate = '" + birthDate + "' where Number = '" + number + "'");

            if (ds != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet getAllLessonCode()
        {
            return makeDBOperations("select Code_ from LessonTable");
        }

        public DataSet getLessonsOfStudent(string number)
        {
            return makeDBOperations("select * from StudentLessonTable where Number = '" + number + "'");
        }
    }
}
