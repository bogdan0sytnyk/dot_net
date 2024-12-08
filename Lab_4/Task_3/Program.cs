using System;

namespace Task_3
{
    class Polynomial
    {
        private int[] coefficients;

        public Polynomial(params int[] coefficients)
        {
            this.coefficients = coefficients;
        }

        public Polynomial(Polynomial other)
        {
            this.coefficients = new int[other.coefficients.Length];
            Array.Copy(other.coefficients, this.coefficients, other.coefficients.Length);
        }

        public static Polynomial operator +(Polynomial a, Polynomial b)
        {
            int maxLength = Math.Max(a.coefficients.Length, b.coefficients.Length);
            int[] resultCoefficients = new int[maxLength];
            for (int i = 0; i < a.coefficients.Length; i++)
            {
                resultCoefficients[i] += a.coefficients[i];
            }

            for (int i = 0; i < b.coefficients.Length; i++)
            {
                resultCoefficients[i] += b.coefficients[i];
            }

            return new Polynomial(resultCoefficients);
        }

        public static Polynomial operator -(Polynomial a, Polynomial b)
        {
            int maxLength = Math.Max(a.coefficients.Length, b.coefficients.Length);
            int[] resultCoefficients = new int[maxLength];
            for (int i = 0; i < a.coefficients.Length; i++)
            {
                resultCoefficients[i] += a.coefficients[i];
            }

            for (int i = 0; i < b.coefficients.Length; i++)
            {
                resultCoefficients[i] -= b.coefficients[i];
            }

            return new Polynomial(resultCoefficients);
        }

        public static Polynomial operator *(Polynomial a, Polynomial b)
        {
            int[] resultCoefficients = new int[a.coefficients.Length + b.coefficients.Length - 1];
            for (int i = 0; i < a.coefficients.Length; i++)
            {
                for (int j = 0; j < b.coefficients.Length; j++)
                {
                    resultCoefficients[i + j] += a.coefficients[i] * b.coefficients[j];
                }
            }

            return new Polynomial(resultCoefficients);
        }

        public static Polynomial operator ++(Polynomial a)
        {
            int[] resultCoefficients = new int[a.coefficients.Length];
            for (int i = 0; i < a.coefficients.Length; i++)
            {
                resultCoefficients[i] = a.coefficients[i] + 1;
            }

            return new Polynomial(resultCoefficients);
        }

        public static Polynomial operator --(Polynomial a)
        {
            int[] resultCoefficients = new int[a.coefficients.Length];
            for (int i = 0; i < a.coefficients.Length; i++)
            {
                resultCoefficients[i] = a.coefficients[i] - 1;
            }

            return new Polynomial(resultCoefficients);
        }

        public int this[int i]
        {
            get
            {
                if (i < 0 || i >= coefficients.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return coefficients[i];
            }
            set
            {
                if (i < 0 || i >= coefficients.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                coefficients[i] = value;
            }
        }

        public static Polynomial operator +(Polynomial a)
        {
            return new Polynomial(a);
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < coefficients.Length; i++)
            {
                if (coefficients[i] != 0)
                {
                    if (i > 0)
                    {
                        result += " + ";
                    }

                    result += coefficients[i];
                    if (i > 0)
                    {
                        result += "x^" + i;
                    }
                }
            }

            return result;
        }
    }
    class Program
    {
        static void DisplayPolynomials(Polynomial[] polynomials)
        {
            foreach (var poly in polynomials)
            {
                Console.WriteLine(poly.ToString());
            }
        }

        static void Main()
        {
            int[] coefficients1 = { 1, 2, 3 }; // Перший многочлен: x^2 + 2x + 3
            int[] coefficients2 = { -1, 0, 1 }; // Другий многочлен: -x^2 + 1
            int[] coefficients3 = { -1, 0, 1 }; // Другий многочлен: -x^2 + 1
            Polynomial poly1 = new Polynomial(coefficients1);
            Polynomial poly2 = new Polynomial(coefficients2);
            Polynomial poly3 = new Polynomial(coefficients3);

            Polynomial[] polynomials = new Polynomial[] { poly1, poly2, poly3};

            Console.WriteLine("Полiноми:");
            DisplayPolynomials(polynomials);
            Polynomial sum = poly1 + poly2 + poly3;
            Console.WriteLine("Сума: " + sum.ToString());
        }
    }
}