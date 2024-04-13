using System.Diagnostics;

public class Delegates
{
    delegate double Function(double x);

    class Multiplier
    {
        double _factor;
        public Multiplier(double factor) => _factor = factor;
        public double Multiply(double x) => _factor * x;
    }

    class DelegateExemple
    {
        static double[] Apply(double[] x, Function f) 
        {
            var result = new double[x.Length];
            for(int i = 0; i < x.Length; i++) result[i] = f(x[i]);
            return result;
        }

        public static void Main()
        {
            double[] a = { 0.0, 0.5, 1.0 };
            double[] squares = Apply(a, (x) => x * x);
            double[] sines = Apply(a, Math.Sin);
            Multiplier m = new(2.0);
            double[] doubles = Apply(a, m.Multiply);
        }
    }
}
