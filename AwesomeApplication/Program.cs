namespace AwesomeApplication
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            TestClass c = new TestClass();

            Console.WriteLine(c.TestString);
            Console.WriteLine("this is a fork.");       
            // made a change
        }
    }
}
