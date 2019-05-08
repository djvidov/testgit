using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace CursePrepation
{
    class Persoana {
        string nume;
        public string Nume {
            get { return nume; }
            set { nume = value; }
        }
        string prenume;
        public string Prenume {
            get { return prenume; }
        }
        int varsta = 18;

        void Caller()
        {
            int age = 7;
            //SchoolReady(age);
        }
        private void MakeHimOld(int age)
        {
            //to do ...
        }

        static void Main(string[] args)
        {
            Console.CancelKeyPress += Console_CancelKeyPress;
            Console.CancelKeyPress += Console_CancelKeyPress1;
            var y = 15.4;
            int x = 20;
            var z = new StringBuilder();

            x += 10;
            Console.WriteLine("Add Assignment: " + x);
            x *= 4;
            Console.WriteLine("Multiply Assignment: " + x);
            x %= 7;
            Console.WriteLine("Modulo Assignment: " + x);
            x &= 10;
            Console.WriteLine("Bitwise And Assignment: " + x);
            x ^= 12;
            Console.WriteLine("Bitwise XOR Assignment: " + x);
            x >>= 3;
            Console.WriteLine("Right Shift Assignment: " + x);
            Console.WriteLine("Press Enter Key to Exit..");
            while (true)
            {
                Thread.Sleep(0);
                Thread.Sleep(1);
                Thread.SpinWait(1);
            }
            Console.ReadLine();
        }

        private static void Console_CancelKeyPress1(object sender, ConsoleCancelEventArgs e)
        {
            throw new NotImplementedException();
        }
        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("Application will be closed in 3 seconds");
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine($"{i}");
                Thread.Sleep(1000);
            }
            Environment.Exit(0);
        }

        private static void Temperatura()
        {
            Fahrenheit fahr = new Fahrenheit(100.0f);
            Console.Write($"{fahr.Degrees} Fahrenheit");
            Celsius c = (Celsius)fahr;
            Celsius c2 = new Celsius(fahr);

            Console.Write($" = {c.Degrees} Celsius");
            Fahrenheit fahr2 = (Fahrenheit)c;
            Fahrenheit f3 = new Fahrenheit(c2);
            Console.WriteLine($" = {fahr2.Degrees} Fahrenheit");
        }

        private static void Cast()
        {
            int num1 = 5;
            ushort num2 = 2;
            double total = (float)num1 / num2;
            Console.WriteLine(total);
        }

        private static void Arrays()
        {
            int[] a1 = new int[10];
            a1[0] = 1;
            a1[1] = 0;
            a1[2] = -1;

            int[,] a2 = new int[10, 5];
            a2[0, 0] = 3;
            a2[0, 1] = 2;

            int[,,] a3 = new int[10, 5, 2];
            a3[0, 0, 0] = 3;
            a3[0, 0, 1] = 3;

            a1[0] = 1;
            a2[0, 0] = 2;
            a3[0, 0, 0] = 3;

        }
    }
}
