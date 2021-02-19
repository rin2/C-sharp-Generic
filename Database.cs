using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Database<T, T2, T3> 
    {
   
        public void add(T name, T surname, T2 weight, T3 date)
        {

            
                Stack<Student> sStudent = new Stack<Student>();

            sStudent.Push(
            new Student()
            {
                Name = name.ToString(),
                SurName = surname.ToString(),

                BithDate = Convert.ToDateTime(date) ,
                Weight = Convert.ToDouble(weight),


            }) ;


            foreach (var item in sStudent)
            {
                Console.WriteLine($" {item}");
            }

        }

    
    }


    class Database2<T, T2, T3, T4>
    {
        public Database2()
        {
        }

        public Database2(T name, T surname, T2 weight, T3 date)
        {
            Name = name;
            Surname = surname;
            Weight = weight;
            Date = date;
        }

        public T Name { get; set; }
        public T Surname { get; set; }
        public T2 Weight { get; set; }
        public T3 Date { get; set; }

        public T4[] Students { get; set; }
        public int StudentsCount { get; set; } = default;
        public void AddStudents(ref T4 studnets)
        {
            T4[] temp = new T4[++StudentsCount];
            if (Students != null)
            {
                Students.CopyTo(temp, 0);

            }
            temp[temp.Length - 1] = studnets;
            Students = temp;


        }


        public void add2(T name, T surname, T2 weight, T3 date)
        {

            
            Stack<Student> sStudent = new Stack<Student>();

            sStudent.Push(
            new Student()
            {
                Name = name.ToString(),
                SurName = surname.ToString(),

                BithDate = Convert.ToDateTime(date),
                Weight = Convert.ToDouble(weight),
            });

            foreach (var item in sStudent)
            {
                Console.WriteLine($" {item}");
            }
        }
    }
}
