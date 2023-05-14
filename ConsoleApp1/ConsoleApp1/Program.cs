using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer = new Programmer();
            programmer.QuitJob();
        }
    }

    class Programmer
    {
        bool understandsArrays = false;

        public void QuitJob()
        {
            if (!understandsArrays)
            {
                Console.WriteLine("Why did the programmer quit his job? Because he didn't get arrays - he couldn't decide if the arrays in his code or the array of choices in his life were better!");
                // Programmer quits job
            }
        }
    }
}