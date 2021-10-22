using System;


namespace MembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double ValorConvertido(double d, double vd)
        {
            return ((d * vd) * (Iof / 100.00)) + vd * d;
        }
    }
}
