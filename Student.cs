using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Student
    {
        public Student(string name, string surName, DateTime bithDate, double weight)
        {
            Name = name;
            SurName = surName;
            BithDate = bithDate;
            Weight = weight;
        }

        public Student()
        {

        }

        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BithDate { get; set; }

        public double Weight { get; set; }

        public override string ToString()
        {
            return $"{Name} \t {SurName} \t {BithDate.ToShortDateString()} \t {Weight}";
        }


        public  void Show()
        {
            Console.WriteLine($" Name: \t\t\t\t {Name} \n Surname: \t\t\t {SurName} \n Age: \t\t\t\t {BithDate} \n Weight: \t\t\t {Weight} ");
        }
    }


}
