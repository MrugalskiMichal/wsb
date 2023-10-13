namespace heron
{
    class program
    {
        static void Main(string[] args)
        {
            bool iscorrect = false;
            do
            {
                Console.WriteLine("Podaj slugosc a");
                double a;
                while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.WriteLine("Błędne dane");
                }
                Console.WriteLine("Podaj slugosc b");
                double b;
                while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.WriteLine("Błędne dane");
                }
                Console.WriteLine("Podaj slugosc c");
                double c;
                while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    Console.WriteLine("Błędne dane");
                }
                if (Czytrojkat(a, b, c))
                {
                    double pole = Obliczenia(a, b, c);
                    Console.OutputEncoding=System.Text.Encoding.Unicode;
                    Console.WriteLine($"pole trojkata o bokach {a}, {b}, {c} wynosi:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{ pole: F5}cn\u00B2");
                    Console.ResetColor();
                    iscorrect = true;
                    Console.OutputEncoding = System.Text.Encoding.Default;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPodane dlugosci nie utworza trojkata!");
                    Console.ResetColor();
                    Thread.Sleep(1700);
                    Console.Clear();
                }

                static bool Czytrojkat(double a, double b, double c)
                {
                    return a + b > c && a + c > b && b + c > a;
                    //if (a+b<=c || b+c<=a || c+a<=b)  
                    //    return false;
                    //return true;

                }
                static double Obliczenia(double a, double b, double c)
                {
                    double P = (a + b + c) / 2;
                    return Math.Sqrt(P * (P - a) * (P - b) * (P - c));

                }

            }
            while (!iscorrect);

        }
        static bool Czytrojkat(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
            //if (a+b<=c || b+c<=a || c+a<=b)  
            //    return false;
            //return true;

        }
        static double Obliczenia(double a, double b, double c)
        {
            double P = (a + b + c) / 2;
            return Math.Sqrt(P * (P - a) * (P - b) * (P - c));

        }


    }
}
