using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Point<T> 
    {
        public Point()
        {
            X = default(T);
            Y = default(T);
        }

        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }

        public T X { get; set; }
        public T Y { get; set; }

      
    }

    class Point2<T> where T:class // ancaq referens type -lar
    {
        public Point2()
        {
            X = default(T);
            Y = default(T);
        }

        public Point2(T x, T y)
        {
            X = x;
            Y = y;
        }

        public T X { get; set; }
        public T Y { get; set; }


    }


    class Point3<T> where T : struct // ancaq referens type -lar
    {
        public Point3()
        {
            X = default(T);
            Y = default(T);
        }

        public Point3(T x, T y)
        {
            X = x;
            Y = y;
        }

        public T X { get; set; }
        public T Y { get; set; }

       

    }
}
