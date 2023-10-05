namespace Lab1_2
{
    internal class Program
    {
        class Fraction : IComparable<Fraction>
        {
            public int Numerator { get; set; }
            public int Denominator { get; set; }


            public Fraction(int numerator, int denominator)
            {
                if (denominator == 0)
                {
                    throw new ArgumentException("Denominator can not be zero");
                }

                Numerator = numerator;
                Denominator = denominator;

                Simplify();
            }

            private void Simplify()
            {
                int gcd = GCD(Numerator, Denominator);
                Numerator /= gcd;
                Denominator /= gcd;

                if (Denominator < 0)
                {
                    Numerator *= -1;
                    Denominator *= -1;
                }
            }


            private int GCD(int a, int b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);

                while (b != 0)
                {
                    int r = a % b;
                    a = b;
                    b = r;
                }

                return a;
            }

            public static Fraction operator +(Fraction a, Fraction b)
            {
                int newNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
                int newDemoniator = a.Denominator * b.Denominator;

                return new Fraction(newNumerator, newDemoniator);
            }

            public static Fraction operator -(Fraction a, Fraction b)
            {
                int newNumerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
                int newDemoniator = a.Denominator * b.Denominator;

                return new Fraction(newNumerator, newDemoniator);
            }

            public static Fraction operator *(Fraction a, Fraction b)
            {
                int newNumerator = a.Numerator * b.Numerator;
                int newDemoniator = a.Denominator * b.Denominator;

                return new Fraction(newNumerator, newDemoniator);
            }

            public static Fraction operator /(Fraction a, Fraction b)
            {
                if (b.Numerator == 0)
                {
                    throw new DivideByZeroException("Can not divide by zero");
                }

                int newNumerator = a.Numerator * b.Denominator;
                int newDemoniator = a.Denominator * b.Numerator;

                return new Fraction(newNumerator, newDemoniator);
            }

            public static bool operator ==(Fraction a, Fraction b)
            {
                return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
            }

            public static bool operator !=(Fraction a, Fraction b)
            {
                return !(a == b);
            }

            public static bool operator <(Fraction a, Fraction b)
            {
                int num1 = a.Numerator * b.Denominator;
                int num2 = a.Denominator * b.Numerator;
                return num1 < num2;
            }

            public static bool operator >(Fraction a, Fraction b)
            {
                int num1 = a.Numerator * b.Denominator;
                int num2 = a.Denominator * b.Numerator;
                return num1 > num2;
            }

            public override string ToString()
            {
                return $"{Numerator}/{Denominator}";
            }

            public override bool Equals(object? obj)
            {
                if (obj is Fraction)
                {
                    return this == (Fraction)obj;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return Numerator.GetHashCode() ^ Numerator.GetHashCode();
            }

            public static implicit operator Fraction(int num)
            {
                return new Fraction(num, 1);
            }

            public static explicit operator double(Fraction fraction)
            {
                return (double)fraction.Numerator / fraction.Denominator;
            }

            public int CompareTo(Fraction other)
            {

                double value1 = (double)Numerator / Denominator;
                double value2 = (double)other.Numerator / other.Denominator;

                return value1.CompareTo(value2);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Fraction a = new Fraction(1, 2);
                Fraction b = new Fraction(3, 4);
                Fraction c = new Fraction(2, 4);

                Fraction sum = a + b;
                Fraction difference = a - b;
                Fraction product = a * b;
                Fraction quotient = a / b;

                // Sử dụng các toán tử +, -, *, / cho phân số.

                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                Console.WriteLine("c = " + c);

                Console.WriteLine();

                Console.WriteLine("a + b = " + sum);
                Console.WriteLine("a - b = " + difference);
                Console.WriteLine("a * b = " + product);
                Console.WriteLine("a / b = " + quotient);

                Console.WriteLine();

                //  Sử dụng toán tử so sánh ==, !=, <, > cho phân số.

                Console.WriteLine("a == b: " + (a == b));
                Console.WriteLine("a == c: " + (a == c));
                Console.WriteLine("a != b: " + (a != b));
                Console.WriteLine("a < b: " + (a < b));
                Console.WriteLine("a > b: " + (a > b));

                Console.WriteLine();

                // Hàm chuyển đổi kiểu ngầm định từ số nguyên ra phân số 

                Console.WriteLine("Implicit type conversion: ");

                int num = 10;
                Fraction fraction = 10;
                Console.WriteLine($"Convert integer: {num}, to fraction: {fraction}");

                Console.WriteLine();

                // Chuyển đổi tường minh từ phân số ra số thực.

                Console.WriteLine("Explicit type conversion: ");

                fraction = new Fraction(2, 3);
                double realNum = (double)fraction;

                Console.WriteLine($"Convert fraction: {fraction}, to real number: {realNum}");

                Console.WriteLine();

                // Implement interface Icomparable, test với phương thức Array.Sort()

                Fraction[] fractions = new Fraction[] {
                    3,
                    new Fraction(6,4),
                    -1,
                    new Fraction(-7,5),
                    0,
                };

                Console.WriteLine("Array: ");
                foreach (var item in fractions)
                {
                    Console.Write(item + ", ");
                }

                Console.WriteLine("\n");


                Array.Sort(fractions);

                Console.WriteLine("Array sorted: ");
                foreach (var item in fractions)
                {
                    Console.Write(item + ", ");
                }

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}