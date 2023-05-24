using System;
namespace IntroCS
{
	public class Person
	{
        public void Test0()
        {
            Console.WriteLine("public method");
        }
        private void Test1()
        {
            Console.WriteLine("private method");
        }
        internal void Test2()
        {
            Console.WriteLine("internal method");
        }
        protected void Test3()
        {
            Console.WriteLine("protected method");
        }
        protected internal void Test4()
        {
            Console.WriteLine("protected internal method");
        }
    }
}

