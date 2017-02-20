using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debuggable
{
    public class Dummy
    {
        public string field = "a";

        public void Method()
        {
            var variable = "value";

            for(int i=0; i < 10; i++)
            {
                var result = ReturnSomething();

                DoSomething();

                variable = variable + (result * 5).ToString();

                Console.WriteLine(variable);
            }
        }

        public int ReturnSomething()
        {
            return 42;
        }

        public void DoSomething()
        {
            if (ReturnSomething() == 1)
            {
                HandleOne();
            }
            else if(ReturnSomething() == 42)
            {
                HandleTwo();
            }
            else{
                HandleElse();
            }
        }

        public void HandleOne()
        {
            Console.WriteLine("One");
        }

        public void HandleTwo()
        {
            Console.WriteLine("Two");
        }

        public void HandleElse()
        {
            Console.WriteLine("Else");
        }
    }


    class Program
    {
        public static string BrokenMethod()
        {
            return null;
        }

        public static string NeedyMethod(int parameter)
        {
            return parameter.ToString();
        }

        public static string SuchImportantMethod()
        {
            return NeedyMethod(BrokenMethod().Length);
        }

        static void Main(string[] args)
        {
            var dummy = new Dummy();
            dummy.Method();

            Console.WriteLine(true ? SuchImportantMethod() : NeedyMethod(2) + "a");
        }
    }
}
