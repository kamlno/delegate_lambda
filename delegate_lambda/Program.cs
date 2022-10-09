using System;

namespace delegate_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Func<int, bool> c = x => x == 5;
            Func<string, bool> b = y => y == "abc";
            var d = MyFunc(c, 5, 10);
            var i = c(8);
            Action<int> AAAA = test;
            aaa = x => x = 999;
            //AAAA = test;

            Console.WriteLine(c(10));
            Console.WriteLine(b("ddd"));

            Program P = new Program();
            var Fle = typeof(Program);
            var Fle2 = P.GetType();
            P.property3 = 9;
            Console.WriteLine(P.property);
            Console.WriteLine(P.property2);
            Console.WriteLine(P.property3);
            var pro1 = Fle.GetProperty("property");
            var pro2 = Fle.GetProperty("property2");
            Console.WriteLine(pro1);
            Console.WriteLine(pro1.GetValue(P));
            Console.WriteLine(pro2);
            Console.WriteLine(pro2.GetValue(P));
        }

        static Func<bool, bool, bool> bbb;
        static Func<string> sss;
        static Action<int> aaa;
        static Action ac;

        public delegate int a(int x, int y);

        public static void test(int x )
        {
            
        }
        public static int MyFunc(Func<int , bool> c , int x , int y )
        {
            c(x);
            bool a = c(6) == (x < y); 
            return x + y;
        }
        public int property => 10; // properties sugar

        public int property2 { get; set; } = 2; //set value 

        //

        public int _property3;

        public int property3  // getter & setter
        {
            get
            {
                return _property3;
            }
            set
            {
                _property3 = value;
            }
        }

        //
    }
}
