namespace lab_10
{

        public class Fraction
        {
            protected double Numer;
            protected double Denom;
            public Fraction(double num, double denom)
            {
                Numer = num;
                Denom = denom;
            }
            public static Fraction operator +(Fraction a, Fraction b)
            {
                Fraction res = new Fraction(a.Numer * b.Denom + a.Denom * b.Numer, a.Denom * b.Denom);
                return res;
            }
            public static Fraction operator -(Fraction a, Fraction b)
            {
                Fraction res = new Fraction(a.Numer * b.Denom - a.Denom * b.Numer, a.Denom * b.Denom);
                return res;
            }
            public static Fraction operator *(Fraction a, Fraction b)
            {
                Fraction res = new Fraction(a.Numer * b.Numer, a.Denom * b.Denom);
                return res;
            }
            public static Fraction operator /(Fraction a, Fraction b)
            {
                Fraction res = new Fraction(a.Numer * b.Denom, a.Denom * b.Numer);
                return res;
            }
            public static Fraction operator ++(Fraction a)
            {
                Fraction res = new Fraction(a.Numer + a.Denom, a.Denom);
                return res;
            }
            public static Fraction operator --(Fraction a)
            {
                Fraction res = new Fraction(a.Numer - a.Denom, a.Denom);
                return res;
            }
            public static bool operator ==(Fraction a, Fraction b)
            {
                if (a.Numer / a.Denom == b.Numer / b.Denom)
                    return true;
                return false;
            }
            public static bool operator >(Fraction a, Fraction b)
            {
                if (a.Numer / a.Denom > b.Numer / b.Denom)
                    return true;
                return false;
            }
            public static bool operator >=(Fraction a, Fraction b)
            {
                if (a.Numer / a.Denom >= b.Numer / b.Denom)
                    return true;
                return false;
            }
            public static bool operator <(Fraction a, Fraction b)
            {
                if (a.Numer / a.Denom < b.Numer / b.Denom)
                    return true;
                return false;
            }
            public static bool operator <=(Fraction a, Fraction b)
            {
                if (a.Numer / a.Denom <= b.Numer / b.Denom)
                    return true;
                return false;
            }
            public static bool operator !=(Fraction a, Fraction b)
            {
                if (a.Numer / a.Denom != b.Numer / b.Denom)
                    return true;
                return false;
            }
            public static explicit operator double(Fraction res)
            {
                return res.Numer / res.Denom;
            }
            public override string ToString()
            {
                return Numer + "/" + Denom;
            }
            public static Fraction Nod(Fraction a)
            {
                double x = Math.Abs(a.Numer);
                double y = Math.Abs(a.Denom);
                if (y % x == 0 && x % x == 0)
                {
                    y /= x;
                    x /= x;
                }
                Fraction res = new Fraction(x, y);
                return res;

            }
        }
}