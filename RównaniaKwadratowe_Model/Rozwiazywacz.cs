using System.Runtime.CompilerServices;

namespace RównaniaKwadratowe_Model
{
    public class RozwiązywaczRównańKwadratowych
    {
        private double a, b, c;

        public double? X1 { get; } = null; // ? oznacza nullable
        public double? X2 { get; } = null;

        public RozwiązywaczRównańKwadratowych(double a, double b, double c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if (a == 0) throw new ArgumentException("Wspolczynnik a nie moze byc 0");

            double delta = b * b - 4*a * c;
           
            if (delta >=0)
            {
                double delta_sqrt = Math.Sqrt(delta);
                X1 = (-b - delta_sqrt) / (2 * a);
                X2 = (-b + delta_sqrt) / (2 * a);
            }

        }

        public override string ToString()
        {
           string s = $"Równanie {a}x^2+{b}x+{c} ";
            if ((X1.HasValue) && (X2.HasValue)) {
                s += " ma wyniki {X1} i {X2}";
            } else
            {
                s += " nie ma rozwiazan";
            }
            return s;
          //  return base.ToString();
        }
    }
}