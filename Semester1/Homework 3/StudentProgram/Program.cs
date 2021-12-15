using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Student
{
    private string name;
    public string state;

    public Student(string name1)
    {
        name = name1;
        state = "";
    }

    public string GetName()
    {
        return name;
    }
    public void Relax()
    {
        state += "Relax ";
    }
    public void Read() {
        state += "Read ";
    }
    public void Write() {
        state += "Write";
    }

    public abstract void Study();
}

class GoodStudent : Student
{
    public GoodStudent(string Name): base(Name)
    {
        state = "Good";
    }

    public override void Study()
    {
        Read();
        Write();
        Read();
        Write();
        Relax();
    }
}

class BadStudent : Student
{
    public BadStudent(string Name) : base(Name)
    {
        state = "Bad";
    }

    public override void Study()
    {
        Relax();
        Relax();
        Relax();
        Relax();
        Read();
    }
}

class Group
{
    public string groupName;
    public List<Student> studentList = new List<Student>();

    public Group(string gname)
    {
        groupName = gname;
        
    }

    public void AddStudent (Student st)
    {
        studentList.Add(st);
    }

    public void GetInfo()
    {
        string result = groupName + ": ";
    
        for (int i= 0; i<studentList.Count(); i++)
        {
            result += studentList[i].GetName();
            if (i != studentList.Count() - 1)
            {
                result += ", ";
            }
        }
        Console.WriteLine(result);
    }
}

namespace StudentProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Enter group's name:");
            string Gname = Console.ReadLine();
            Group g = new Group(Gname);
            Console.WriteLine("Now enter number of students:");
            string N = Console.ReadLine();
            int n = Convert.ToInt32(N);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter student's name:");
                string name1 = Console.ReadLine();
                Console.WriteLine("Now is this student good or bad?");
                string state1 = Console.ReadLine();
                if (state1 == "good")
                {
                    GoodStudent s = new GoodStudent(name1);
             
                    g.AddStudent(s);
                }
                else
                {
                    BadStudent s = new BadStudent(name1);
                    g.AddStudent(s);
                }
            }
            g.GetInfo();

        }
    }
}
