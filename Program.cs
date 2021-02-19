using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region NonGeneric

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n Non Generic");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" ================================================================== \n");
            Console.ForegroundColor = ConsoleColor.White;

            System.Collections.ArrayList arrayList = new System.Collections.ArrayList(); //non generic
            arrayList.Add(1);
            arrayList.Add("Azad");
            arrayList.Add('a');

            System.Collections.ArrayList arrayList2 = new System.Collections.ArrayList(); //non generic
            arrayList2.Add(12);
            arrayList2.Add("Azad2");
            arrayList2.Add('b');


            Console.WriteLine($"\n ArrayList arrayList ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in arrayList)
            {
                Console.WriteLine($" {item}");
            }



            arrayList.AddRange(arrayList2);

            Console.WriteLine($"\n\n ArrayList arrayList.AddRange(arrayList2) ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in arrayList)
            {
                Console.WriteLine($" {item}");
            }

            arrayList.Remove(12);

            Console.WriteLine($"\n\n ArrayList arrayList.Remove(12) ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in arrayList)
            {
                Console.WriteLine($" {item}");
            }


            arrayList.RemoveAt(1);

            Console.WriteLine($"\n\n ArrayList arrayList.RemoveAt(1) ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in arrayList)
            {
                Console.WriteLine($" {item}");
            }

            arrayList.RemoveRange(0, 3);

            Console.WriteLine($"\n\n ArrayList arrayList.RemoveRange(2, 3) ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in arrayList)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine($"\n ArrayList Capacity:  {arrayList.Capacity}");
            Console.WriteLine($" ArrayList Count:  {arrayList.Count}");

            arrayList.Clear();

            Console.WriteLine($"\n\n ArrayList arrayList.Clear() ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in arrayList)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine($"\n\n ArrayList Capacity:  {arrayList.Capacity}");
            Console.WriteLine($" ArrayList Count:  {arrayList.Count}");

            arrayList.TrimToSize();

            Console.WriteLine($"\n\n ArrayList arrayList.TrimToSize() ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in arrayList)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine($"\n\n ArrayList Capacity:  {arrayList.Capacity}");
            Console.WriteLine($" ArrayList Count:  {arrayList.Count}");

            string word = "Salam";
            string word2 = "Salam";
            Console.WriteLine($"\n\n {word}: GetHashCode -> {word.GetHashCode()}");
            Console.WriteLine($" {word2}: GetHashCode -> {word2.GetHashCode()}");


            User user = new User
            {
                Name = "John",
                SurName = "Johnlu"
            };

            Console.WriteLine($" {user}: GetHashCode -> {user.GetHashCode()}");


            Console.WriteLine();

            System.Collections.Stack stack = new System.Collections.Stack();

            stack.Push(10);
            stack.Push("Salam");
            stack.Push("12");
            stack.Push('s');

            Console.WriteLine($"\n Stack stack ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in stack)
            {
                Console.WriteLine($" {item}");
            }



            Console.WriteLine($"\n Stack stack.Pop() ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" stack.Pop(): {stack.Pop()}");

            foreach (var item in stack)
            {
                Console.WriteLine($" {item}");
            }


            Console.WriteLine($"\n Stack stack.Peek() ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" stack.Peek(): {stack.Peek()}");

            stack.Clear();

            Console.WriteLine($"\n Stack stack.Clear() ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in stack)
            {
                Console.WriteLine($" {item}");
            }

            System.Collections.Queue queue = new System.Collections.Queue();

            queue.Enqueue(15);
            queue.Enqueue("RS");
            queue.Enqueue("1258");
            queue.Enqueue('F');

            Console.WriteLine($"\n Queue queue ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in queue)
            {
                Console.WriteLine($" {item}");
            }


            Console.WriteLine($"\n Queue queue.Dequeue() ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" queue.Dequeue() : {queue.Dequeue()}");

            foreach (var item in queue)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine($"\n Queue queue.Peek() ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" queue.Peek(): {queue.Peek()}");


            System.Collections.Hashtable hashtable = new System.Collections.Hashtable();
            hashtable.Add("apple", "alma");
            hashtable.Add("ball", "top");
            hashtable.Add("yellow", "sarı");
            hashtable.Add("red", "qırmızı");


            Console.WriteLine($"\n Hashtable hashtable ");
            Console.WriteLine($" ================================================================== ");
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine($" {key} - {hashtable[key]}");
            }

            hashtable.Remove("apple");

            Console.WriteLine($"\n Hashtable hashtable.Remove(\"apple\") ");
            Console.WriteLine($" ================================================================== ");
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine($" {key} - {hashtable[key]}");
            }

            Console.WriteLine($"\n Hashtable hashtable.GetHashCode() ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" {hashtable.GetHashCode()}");

            Console.WriteLine($"\n Hashtable hashtable.ContainsKey ");
            Console.WriteLine($" ================================================================== ");
            var key1 = "red";
            Console.WriteLine($" {key1} - {hashtable.ContainsKey(key1)}");

            Console.WriteLine($"\n Hashtable hashtable.ContainsValue ");
            Console.WriteLine($" ================================================================== ");
            var key2 = "qırmızı";
            Console.WriteLine($" {key2} - {hashtable.ContainsValue(key2)}");

            System.Collections.SortedList sortedList = new System.Collections.SortedList();
            sortedList.Add("nar", "pomegranate");
            sortedList.Add("alma", "apple");
            sortedList.Add("ananas", "pineapple");
            sortedList.Add("banan", "banana");

            Console.WriteLine($"\n SortedList sortedList ");
            Console.WriteLine($" ================================================================== ");
            foreach (var key in sortedList.Keys)
            {
                Console.WriteLine($" {key} - {sortedList[key]}");
            }

            sortedList.Remove("banan");

            Console.WriteLine($"\n SortedList sortedList.Remove(\"banan\") ");
            Console.WriteLine($" ================================================================== ");
            foreach (var key in sortedList.Keys)
            {
                Console.WriteLine($" {key} - {sortedList[key]}");
            }

            #endregion NonGeneric

            #region Generic
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n Generic");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" ================================================================== \n");
            Console.ForegroundColor = ConsoleColor.White;

            Queue<double> q = new Queue<double>();

            q.Enqueue(1);
            q.Enqueue(2.5);
            q.Enqueue(22.5);
            q.Enqueue(5);

            Console.WriteLine("\n Queue<double>");
            Console.WriteLine($" ================================================================== ");
            foreach (var item in q)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine($"\n Queue<double> q.Dequeue() ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" q.Dequeue() : {q.Dequeue()}");

            foreach (var item in q)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine($"\n Queue<double> q.Peek() ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" q.Peek(): {q.Peek()}");


            Stack<double> s = new Stack<double>();

            s.Push(1.2);
            s.Push(2);
            s.Push(5.2);
            s.Push(0.56);

            Console.WriteLine($"\n Stack<double> ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in s)
            {
                Console.WriteLine($" {item}");
            }



            Console.WriteLine($"\n  Stack<double> s.Pop() ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" s.Pop(): {s.Pop()}");

            foreach (var item in s)
            {
                Console.WriteLine($" {item}");
            }


            Console.WriteLine($"\n Stack<double> s.Peek() ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" s.Peek(): {s.Peek()}");

            s.Clear();

            Console.WriteLine($"\n Stack<double> s.Clear() ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in s)
            {
                Console.WriteLine($" {item}");
            }


            List<double> list = new List<double>();
            list.Add(12.3);
            list.Add(1);
            list.Add(12.6);
            list.Add(2);

            Console.WriteLine($"\n  List<double> ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in list)
            {
                Console.WriteLine($" {item}");
            }


            list.Remove(12.3);
            Console.WriteLine($"\n  List<double> list.Remove(12.3)");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in list)
            {
                Console.WriteLine($" {item}");
            }

            list.RemoveAll(l => l.ToString().Contains("12.6"));

            Console.WriteLine($"\n  List<double> list.RemoveAll(l => l.ToString().Contains(\"12.6\")");
            Console.WriteLine($" ================================================================== ");
            foreach (var item in list)
            {
                Console.WriteLine($" {item}");
            }

            System.Collections.Generic.LinkedList<string> linkedlist = new System.Collections.Generic.LinkedList<string>();
            linkedlist.AddLast("S");
            linkedlist.AddLast("T");
            linkedlist.AddFirst("V");
            linkedlist.AddFirst("U");
            linkedlist.AddLast("S");

            Console.WriteLine($"\n  LinkedList<string> ");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in linkedlist)
            {
                Console.WriteLine($" {item}");
            }

            LinkedListNode<string> newNode = linkedlist.AddLast("B");
            linkedlist.AddAfter(newNode, "P");


            Console.WriteLine($"\n  LinkedList<string> linkedlist.AddAfter()");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in linkedlist)
            {
                Console.WriteLine($" {item}");
            }

            LinkedListNode<string> newNode2 = linkedlist.AddFirst("A");
            linkedlist.AddBefore(newNode2, "H");

            Console.WriteLine($"\n  LinkedList<string> linkedlist.AddBefore()");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in linkedlist)
            {
                Console.WriteLine($" {item}");
            }



            linkedlist.Remove("S");
            Console.WriteLine($"\n  LinkedList<string> linkedlist.Remove(\"S\")");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in linkedlist)
            {
                Console.WriteLine($" {item}");
            }

            linkedlist.RemoveFirst();
            Console.WriteLine($"\n  LinkedList<string> linkedlist.RemoveFirst()");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in linkedlist)
            {
                Console.WriteLine($" {item}");
            }

            linkedlist.RemoveLast();
            Console.WriteLine($"\n  LinkedList<string> linkedlist.RemoveLast()");
            Console.WriteLine($" ================================================================== ");

            foreach (var item in linkedlist)
            {
                Console.WriteLine($" {item}");
            }

            LinkedListNode<string> linkedListNode = linkedlist.Find("T");

            Console.WriteLine($"\n  LinkedList<string> linkedlist.Find()");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" {linkedListNode.Value}");


            Dictionary<string, List<string>> ypx = new Dictionary<string, List<string>>();

            ypx["11AA111"] = new List<string>();
            ypx["11AA111"].Add(" A ");
            ypx["11AA111"].Add(" B ");
            ypx["11AA111"].Add(" C ");
            ypx["11AA111"].Add(" D ");


            Console.WriteLine($"\n  Dictionary <string, List<string>> ");
            Console.WriteLine($" ================================================================== ");
            ypx["11AA111"].ForEach(d =>
            {
                Console.WriteLine(d);
            });

            var resault = ypx.TryGetValue("11AA112", out List<string> value);

            Console.WriteLine($"\n  Dictionary <string, List<string>> TryGetValue()");
            Console.WriteLine($" ================================================================== ");
            if (resault)
            {
                ypx["11AA111"].ForEach(d =>
                {
                    Console.WriteLine(d);
                });
            }
            else
            {
                Console.WriteLine(" Not found");
            }
            Console.WriteLine($"\n  Dictionary <string, List<string>> Count()");
            Console.WriteLine($" ================================================================== ");

            Console.WriteLine($" {ypx.Count}");

            ypx.Remove("11AA111");

            Console.WriteLine($"\n  Dictionary <string, List<string>> Count() After remove");
            Console.WriteLine($" ================================================================== ");

            Console.WriteLine($" {ypx.Count}");



            Queue<Student> qStudent = new Queue<Student>();

            qStudent.Enqueue(
            new Student()
            {
                Name = "Hesen",
                SurName = "Baqirzade",
                BithDate = new DateTime(2012, 10, 11),
                Weight = 75
            });

            qStudent.Enqueue(
            new Student()
            {
                Name = "Adil",
                SurName = "Asifzade",
                BithDate = new DateTime(2003, 4, 20),
                Weight = 60
            });

            qStudent.Enqueue(
            new Student()
            {

                Name = "Oktay",
                SurName = "Hesanzade",
                BithDate = new DateTime(1995, 8, 20),
                Weight = 75

            });

            qStudent.Enqueue(
            new Student()
            {

                Name = "Negiz",
                SurName = "Adilova",
                BithDate = new DateTime(2000, 12, 11),
                Weight = 80

            });

            Console.WriteLine("\n Queue<Student>");
            Console.WriteLine($" ================================================================== ");
            foreach (var item in qStudent)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine($"\n Queue<Student> qStudent.Dequeue() ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" q.Dequeue() : {qStudent.Dequeue()} \n");

            foreach (var item in qStudent)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine($"\n Queue<Student> qStudent.Peek() ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" q.Peek(): {qStudent.Peek()} \n");


            Stack<Student> sStudent = new Stack<Student>();

            sStudent.Push(
            new Student()
            {
                Name = "Hesen",
                SurName = "Hesenli",
                BithDate = new DateTime(2012, 10, 11),
                Weight = 75
            });

            sStudent.Push(
           new Student()
           {
               Name = "Naile",
               SurName = "Nailli",
               BithDate = new DateTime(2012, 10, 11),
               Weight = 75
           });

            sStudent.Push(
           new Student()
           {
               Name = "Oktay",
               SurName = "Veliyev",
               BithDate = new DateTime(2012, 10, 11),
               Weight = 75
           });

            sStudent.Push(
           new Student()
           {
               Name = "Sirin",
               SurName = "Sirinli",
               BithDate = new DateTime(2012, 10, 11),
               Weight = 75
           });


            Console.WriteLine("\n Stack<Student>");
            Console.WriteLine($" ================================================================== ");
            foreach (var item in sStudent)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine($"\n Stack<Student> sStudent.Pop() \n");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" s.Pop(): {sStudent.Pop()}");

            foreach (var item in sStudent)
            {
                Console.WriteLine($" {item}");
            }


            Console.WriteLine($"\n Stack<Student> sStudent.Peek() ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" s.Peek(): {sStudent.Peek()}");


            Point<int> point = new Point<int>(10, 20);

            Console.WriteLine($"\n Point<int> ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" X = {point.X} ; Y = {point.Y}");

            Point<string> point2 = new Point<String>("A", "B");

            Console.WriteLine($"\n Point<string> ");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" X = {point2.X} ; Y = {point2.Y}");


            Point2<string> pointref = new Point2<string>("A2", "B2");
            Console.WriteLine($"\n Point2<string> only for referance types");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" X = {pointref.X} ; Y = {pointref.Y}");


            Point3<int> pointval = new Point3<int>(22, 11);

            Console.WriteLine($"\n Point<int>  only for value types");
            Console.WriteLine($" ================================================================== ");
            Console.WriteLine($" X = {pointval.X} ; Y = {pointval.Y}");

    

            Database<string,int, DateTime> pS = new Database<string,int, DateTime>();
            var date = new DateTime(2015, 10, 11);
            var date2 = new DateTime(2012, 10, 11);
            Console.WriteLine($"\n Database<string,int, DateTime> pS.add()");
            Console.WriteLine($" ================================================================== ");
            pS.add("Azer","Azerli",50, date);
            pS.add("Hesen", "Azerli", 60, date2);

            Student student = new Student("Veli","Bilalov",date,65);
            Database2<string, int, DateTime,Student> ds2 = new Database2<string, int, DateTime, Student>();
            Console.WriteLine($"\n Database2<string, int, DateTime, Student> pS.add()");
            Console.WriteLine($" ================================================================== ");
            ds2.AddStudents(ref student);
            student.Show();
            Student student2 = new Student();
            Console.WriteLine($"\n Database2<string, int, DateTime> pS.add2()");
            Console.WriteLine($" ================================================================== ");
            ds2.add2("Xeyal", "Azerli", 50, date);


            #endregion Generic

            Console.ReadKey();
        }
    }
}
